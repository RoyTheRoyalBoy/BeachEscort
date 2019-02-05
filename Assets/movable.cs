using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movable : MonoBehaviour {
    Rigidbody2D rb;
    public GameObject countdown;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>(); 
	}
	
	// Update is called once per frame
	void Update () {
		if (countdown.GetComponent<countdown>().timer < 0)
        {
            rb.velocity = new Vector2(1, 0);
        }
	}

    void OnCollisionEnter2D(Collision2D coll)
    {
        rb.velocity = Vector2.zero;
    }
}
