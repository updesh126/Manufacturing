using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarColor : MonoBehaviour
{
    public GameObject oldObject;
    public GameObject newObject;
    private bool NewCar = false;
    
    public void show()
    {
        StartCoroutine(ColorChange());
    }
    IEnumerator ColorChange()
    {
        yield return new WaitForSeconds(5);
        oldObject.SetActive(false);
        newObject.SetActive(true);
     
    }

}
