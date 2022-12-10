using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectionTrigger : MonoBehaviour
{
    public GameObject InfoObject;
    private bool Show = false;
    void OnTriggerEnter (Collider Cube)
    {
        if (!Show)
        {
            InfoObject.SetActive(true);
            Show = true;
        }
        else
        {
            InfoObject.SetActive(false);
            Show = false;
        }
    }

    // void OnTriggerStay (Collider Cube)
    // {
    //     InfoObject.SetActive(true);
    //     Show = true;
    // }

    void OnTriggerExit (Collider Cube)
    {
        InfoObject.SetActive(false);
        Show = false;
    }
}
