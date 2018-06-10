using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class clock : MonoBehaviour {

    String time;
    Text text;

    // Use this for initialization
    void Start () {

        text = GameObject.Find("Text").GetComponent<Text>();
        

	}
	
	// Update is called once per frame
	void Update () {

        text.text = (
            "Year: " + System.DateTime.Now.Year.ToString() + "\n" +
            "Month: " + System.DateTime.Now.Month.ToString() + "\n" +
            "Day: " + System.DateTime.Now.Day.ToString() + "\n" +
            "Hour: " + System.DateTime.Now.Hour.ToString() + "\n" +
            "Minute: " + System.DateTime.Now.Minute.ToString() + "\n" +
            "Second: " + System.DateTime.Now.Second.ToString() + "\n" +
            "It's a " + System.DateTime.Now.DayOfWeek.ToString());

        if (Input.GetKey(KeyCode.Space))
        {
            time = System.DateTime.Now.TimeOfDay.ToString();

            Debug.Log("The time is " + time);

            
        }

       
		
	}
}
