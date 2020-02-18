using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public GameObject rotateScript;


    void OnMouseDown()
    {
        rotateScript.GetComponent<RotateHand>().enabled = !rotateScript.GetComponent<RotateHand>().enabled;
    }
}
