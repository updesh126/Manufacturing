using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarColor : MonoBehaviour
{
    public GameObject oldObject;
    public GameObject newObject;
    public GameObject Error;
    public GameObject Done;
    private bool NewCar = false;
    private bool Button = false;
    
    public void show()
    {
        StartCoroutine(ColorChange());
    }
    IEnumerator ColorChange()
    {
        yield return new WaitForSeconds(5);
        oldObject.SetActive(false);
        newObject.SetActive(true);
        NewCar = true;
     
    }
    public void Stope()
    {
        if (NewCar == true)
        {
            Button = false;
        }
        else
        {
            Button = true;
        }
        Warrning();
    }
    private void Warrning()
    {
        if (Button == false)
        {
            Error.SetActive(true);
        }
        else
        {
            Done.SetActive(true);
        }
    }

}
