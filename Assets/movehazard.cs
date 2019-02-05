using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movehazard : MonoBehaviour
{

    Rigidbody2D rb;
    public GameObject countdown;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (countdown.GetComponent<countdown>().timer < 0)
        {
            transform.Translate(Vector2.left * Time.deltaTime);
        }
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "hazard" || coll.gameObject.tag == "ramp up" || coll.gameObject.tag == "ramp down" || coll.gameObject.tag == "moving" || coll.gameObject.tag == "terrain")
        {
            /*if (rb.velocity == new Vector2(-3, 0))
            {
                rb.velocity = new Vector2(3, 0);
            }
            else if (rb.velocity == new Vector2(3, 0))
            {
                rb.velocity = new Vector2(-3, 0);
            }*/
            transform.Rotate(0, 180, 0);
        }

    }
}
