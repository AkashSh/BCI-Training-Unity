using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {
    public GameObject stimulater;
    public float frequency; 
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
        //Debug.Log(panel.activSelf);
        stimulater.SetActive(!stimulater.activeSelf);
    }
}

/* using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flickering : MonoBehaviour {
    public GameObject control;
    public GameObject panel;
    public float frequency;

    // Use this for initialization

    private void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            InvokeRepeating("invoke", 1, 1 / frequency);
        }

        

        
    }
    // Update is called once per frame


    void invoke()
    {
       // Debug.Log(panel.activeSelf);

        panel.SetActive(!panel.activeSelf);
        control.SetActive(!control.activeSelf);
    }


}
*/