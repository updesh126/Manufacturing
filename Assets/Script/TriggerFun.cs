using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerFun : MonoBehaviour
{
    public GameObject InfoObject;
    private bool Show = false;
    void OnTriggerEnter(Collider Cube)
    {
            InfoObject.SetActive(false);
            Show = false;
    }

    // void OnTriggerStay (Collider Cube)
    // {
    //     InfoObject.SetActive(true);
    //     Show = true;
    // }

    /*void OnTriggerExit(Collider Cube)
    {
        InfoObject.SetActive(false);
        Show = false;
    }*/

}
