using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Speedometer : MonoBehaviour
{
    private void Start()
    {
        Speed();
    }
    public static void Speed()
    {
        double speed = 0; // initialize speed to 0

        while (true)
        {
            // simulate increasing speed over time
            speed += 5;
            Debug.Log("Current speed: " + speed + " mph");
            if(speed >= 10000)
            {
                break;
            }
        }
    }
}
