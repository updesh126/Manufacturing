﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PathCreation;

public class Follow : MonoBehaviour
{
    public PathCreator pathCreator;
    public float speed = 2;
    float distanceTravelled;
    private void Update()
    {
        distanceTravelled += speed * Time.deltaTime;
        transform.position = pathCreator.path.GetPointAtDistance(distanceTravelled);
        transform.rotation = pathCreator.path.GetRotationAtDistance(distanceTravelled);
    }
}
