using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DipCar : MonoBehaviour
{
    public GameObject Chain;
    public GameObject body;
    public Vector3 Position;
    bool isChild= false;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("chain"))
        {
            Debug.Log("Heelo"); 
            body.transform.SetParent(Chain.transform);
            body.transform.localPosition = Position;
            body.transform.Rotate(0, 0, 0);
        }
    }
}
