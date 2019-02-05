using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class turtlemove : MonoBehaviour {
    Rigidbody2D rb;
    public GameObject countdown; 
    Animator animator;
    PolygonCollider2D self;
    public bool dead = false;
    public bool up = false;
    int count = 0;

    
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        rb.gravityScale = 0;
        animator.speed = 0;
        self = gameObject.GetComponent<PolygonCollider2D>();
        self.enabled = false;
    }
	
	// Update is called once per frame
	void Update () {
        if (dead == false && countdown.GetComponent<countdown>().timer < 0)
        {
            self.enabled = true;
            animator.speed = 1;
            rb.gravityScale = 1;
            transform.Translate(Vector2.right * Time.deltaTime);
        }
        else if (dead == true)
        {
            count++;
            rb.velocity = Vector2.zero;
            transform.Translate(Vector2.zero);
        }
        if (countdown.GetComponent<countdown>().timer < -20 && Mathf.Round(gameObject.transform.position.x) < 8)
        {
            dead = true;
        }
        if (count == 30)
        {
            animator.speed = 0;
        }
        if (Mathf.Round(gameObject.transform.position.x) >= 8)
        {
            up = true;
            if (SceneManager.GetActiveScene().name == "one")
            {
                
                if (Input.GetKeyDown("space"))
                {
                    SceneManager.LoadScene("two");
                }
                    
            }
            else if (SceneManager.GetActiveScene().name == "two")
            {
                rb.velocity = Vector3.zero;
                transform.Translate(Vector3.zero);

                if (Input.GetKeyDown("space"))
                {
                    SceneManager.LoadScene("three");
                }
            }
            else if (SceneManager.GetActiveScene().name == "three")
            {
                rb.velocity = Vector3.zero;
                transform.Translate(Vector3.zero);

                if (Input.GetKeyDown("space"))
                {
                    SceneManager.LoadScene("four");
                }
            }
            else if (SceneManager.GetActiveScene().name == "four")
            {
                rb.velocity = Vector3.zero;
                transform.Translate(Vector3.zero);

                if (Input.GetKeyDown("space"))
                {
                    SceneManager.LoadScene("five");
                }
            }
            else if (SceneManager.GetActiveScene().name == "five")
            {
                rb.velocity = Vector3.zero;
                transform.Translate(Vector3.zero);

                if (Input.GetKeyDown("space"))
                {
                    SceneManager.LoadScene("six");
                }
            }
            else if (SceneManager.GetActiveScene().name == "six")
            {
                rb.velocity = Vector3.zero;
                transform.Translate(Vector3.zero);

                if (Input.GetKeyDown("space"))
                {
                    SceneManager.LoadScene("seven");
                }
            }
            else if (SceneManager.GetActiveScene().name == "seven")
            {
                rb.velocity = Vector3.zero;
                transform.Translate(Vector3.zero);

                if (Input.GetKeyDown("space"))
                {
                    SceneManager.LoadScene("eight");
                }
            }
            else if (SceneManager.GetActiveScene().name == "eight")
            {
                rb.velocity = Vector3.zero;
                transform.Translate(Vector3.zero);

                if (Input.GetKeyDown("space"))
                {
                    SceneManager.LoadScene("one");
                }
            }
            up = true; 
        }
        if (dead == true && Input.GetKeyDown("space"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "hazard")
        {
            dead = true;
            rb.velocity = Vector2.zero;
            animator.SetTrigger("Die");
        }
    }

    void OnCollisionStay2D(Collision2D coll)
    {
        if(coll.gameObject.tag == "ramp up")
        {

            //transform.Translate(new Vector2(1,2) * Time.deltaTime);
            //rb.gravityScale = 0;
            rb.velocity = new Vector2(.5f, .5f);
        }
        else if (coll.gameObject.tag == "ramp down")
        {
            rb.velocity = new Vector2(.5f, .5f);
        }
        else if (coll.gameObject.tag == "moving" && gameObject.GetComponent<Rigidbody2D>().velocity != Vector2.zero)
        {
            rb.velocity = Vector2.zero;
        }
        else if (coll.gameObject.tag == "moving" && gameObject.GetComponent<Rigidbody2D>().velocity == Vector2.zero)
        {
            rb.velocity = new Vector2(1, 0);
        }
    }
}
