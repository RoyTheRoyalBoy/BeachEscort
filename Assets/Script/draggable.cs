using UnityEngine;
using System.Collections;


public class draggable : MonoBehaviour
{
    public GameObject countdown;
    public float moveSpeed;
    public float offset = 0.05f;
    private bool following;
    // Use this for initialization
    void Start()
    {
        following = false;
        offset += 10;
    }

    // Update is called once per frame
    void Update()
    {
        if (countdown.GetComponent<countdown>().timer < 0)
        {
            return;
        }
        if (Input.GetMouseButtonDown(0) && ((Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position).magnitude <= offset))
        {
            if (following == true)
            {
                following = false;
            }
            else 
                following = true;
        }
        if (following)
        {
            transform.position = Vector2.Lerp(transform.position, Camera.main.ScreenToWorldPoint(Input.mousePosition), moveSpeed);
        }
    }

}