using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class New : MonoBehaviour{
    Vector3 End;
    Vector3 Start1;
    public float fraction_of_way_there;

    void Start(){
        Start1 = transform.position;
        End = transform.position + new Vector3(21.69f,7.487064f,2.9f);
    }
    void Update(){
        fraction_of_way_there += 0.01f;
        transform.position = Vector3.Lerp(Start1,End,fraction_of_way_there);
    }
}
