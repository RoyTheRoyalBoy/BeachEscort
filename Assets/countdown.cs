using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class countdown : MonoBehaviour {
    public float timer = 15;
    public Text text;
    GameObject player;
    void Awake()
    {
        player = GameObject.FindWithTag("Player");
    }
    // Use this for initialization
    void Start () {
       
       
	}
	
	// Update is called once per frame
	void Update () {
        timer -= Time.deltaTime;
        text.text = Mathf.Round(timer) + " Seconds To Set Up!";
        if (timer < 0)
        {
            text.text = "";
        }
        if (player.GetComponent<turtlemove>().dead == true)
        {
            text.text = "You Failed! Press SpaceBar to Restart";
        }
        else if (player.GetComponent<turtlemove>().up == true && SceneManager.GetActiveScene().name == "two")
        {
            text.text = "YOU WON! Press SpaceBar to Restart!";
        }
        else if (player.GetComponent<turtlemove>().up == true)
        {
            text.text = "Good Job! Press SpaceBar to Move On!";
        }

	}
}
