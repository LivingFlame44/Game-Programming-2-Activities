using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script : MonoBehaviour
{
    public Days days;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        switch (days)
        {
            case Days.Monday: Debug.Log("Monday"); break;
            case Days.Tuesday: Debug.Log("Tuesday"); break;
            case Days.Wednesday: Debug.Log("Wednesday"); break;
            case Days.Thursday: Debug.Log("Thursday"); break;
            case Days.Friday: Debug.Log("Friday"); break;
            case Days.Saturday: Debug.Log("Saturday"); break;
            case Days.Sunday: Debug.Log("Sunday"); break;
        }
    }
}
