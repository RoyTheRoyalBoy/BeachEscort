using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class frozenhazard : MonoBehaviour {
    Rigidbody2D rb;
    public GameObject countdown;
    PolygonCollider2D self;
    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0;
        self = gameObject.GetComponent<PolygonCollider2D>();
        self.enabled = false;
    }
	
	// Update is called once per frame
	void Update () {
        if (countdown.GetComponent<countdown>().timer < 0)
        {
            self.enabled = true;
            rb.gravityScale = 1;
        }

    }
}
