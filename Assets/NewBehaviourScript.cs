using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {
    public GameObject stimulater;
    public float frequency;
    public float b;
 
    // Update is called once per frame
    private void Update()
    {
        if (b<1)
        {
            InvokeRepeating("invoke", 0 , 1 / frequency);
           
        }
        else {
            CancelInvoke("invoke"); 
        }
    }
    void invoke ()
    {   
        stimulater.SetActive(!stimulater.activeSelf);
        // Debug.Log(b);
        
    }
}
