using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Threading.Tasks;
using TMPro;
public class Speedometer : MonoBehaviour
{
    public TMP_Text Txt;
    private void Start()
    {
        Speed();
    }
    public async void Speed()
    {
        double speed = 0; // initialize speed to 0

        while (true)
        {
            // simulate increasing speed over time
            speed += 5;
            Txt.text = speed.ToString();
            Debug.Log("Current speed: " + speed + " mph");
            if(speed >= 1000)
            {
                break;
            }
            await Task.Delay(2000); // delay for 2 seconds
        }
    }
}