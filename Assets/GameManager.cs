using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class GameManager : MonoBehaviour {

    StreamReader reader;
    string day = System.DateTime.Now.DayOfWeek.ToString();
    List<string> daysEvents = new List<string>();
    string currentTime = System.DateTime.Now.Hour.ToString() + ":" + System.DateTime.Now.Minute.ToString();


    // Use this for initialization
    void Start () {

        Debug.Log(day);

        CompileDaysEvents();




    }

    void CheckCurrentTime()
    {
        string s = System.DateTime.Now.Hour.ToString() + ":" + System.DateTime.Now.Minute.ToString();
        if (currentTime != s)
        {
            currentTime = s;
            CheckEventSchedule();
        }
    }

    void CompileDaysEvents()
    {
        daysEvents.Clear();

        reader = new StreamReader("Assets/Resources/testtext.txt");

        for (int i = 0; !reader.EndOfStream; i++)
        {

            string line = reader.ReadLine();
            
            string[] conversation = line.Split('\t');

            if (conversation[0].Contains(day))
            {
                daysEvents.Add(line);
            }         

        }

    }

    void CheckEventSchedule()
    {
        
        Debug.Log("currentTime " + currentTime);

        for (int i = 0; i < daysEvents.Count; i++)
        {
            string[] ev = daysEvents[i].Split('\t');

            if(ev[1] == currentTime)
            {
                Debug.Log("event triggered");
                
            }

        }
        
    }

    void CheckWhatDayItIs()
    {
        if (day != System.DateTime.Now.DayOfWeek.ToString())
        {
            day = System.DateTime.Now.DayOfWeek.ToString();
            CompileDaysEvents();
        }
    }



    // Update is called once per frame
    void Update ()
    {
        CheckWhatDayItIs();
        CheckCurrentTime();


    }
}
