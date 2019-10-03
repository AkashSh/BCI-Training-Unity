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
        if (Input.GetKeyDown("space"))
        {
            InvokeRepeating("invoke", 1, 1 / frequency);
           
        }
    }
    void invoke ()
    {
        if ( b == 0 )
        { stimulater.SetActive(!stimulater.activeSelf);
        }
        Debug.Log(b);
       

        
    }
}
