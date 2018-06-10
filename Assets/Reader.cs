using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class Main : MonoBehaviour {

    StreamReader reader;
    List<string> lines = new List<string>();


	// Use this for initialization
	void Start () {

        reader = new StreamReader("Assets/Resources/test.csv");

        //lines.

        //Debug.Log(reader.ReadLine());

    }



    // Update is called once per frame
    void Update () {
		
	}
}
