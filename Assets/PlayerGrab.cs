﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGrab : MonoBehaviour
{
    public GameObject ball;
    public GameObject myHand;
    public GameObject LocPlane;
    public Vector3 Posstion;
    public Vector3 Rotation;

    bool inHands =false;
    // Start is called before the first frame update
    void Start()
    {
       // ballPos = LocPlane.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public void GrabObj()
    {
        //if (Input.GetButtonDown("Fire1"))
        //{
            if (!inHands)
            {
                ball.transform.SetParent(myHand.transform);
                ball.transform.localPosition = myHand.transform.localPosition;
                ball.transform.Rotate(0, 0, 0);
                inHands = true;
            }
        //}
    }
    public void Relase()
    {
        if (inHands)
        {
            ball.transform.SetParent(LocPlane.transform);
            ball.transform.localPosition = Posstion;
            ball.transform.eulerAngles = Rotation;
            inHands = false;
        }
    }
    public void RelaseTir()
    {
        if (inHands)
        {
            ball.transform.SetParent(null);
            ball.transform.localPosition = Posstion;
            ball.transform.eulerAngles = Rotation;
            Destroy(ball.GetComponent("Button"));
            inHands = false;
        }
    }
}
