using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Directionguid : MonoBehaviour
{
    public GameObject go1;
    public GameObject go2;
    public GameObject go3;
    public GameObject go4;
    [SerializeField]


    // Start is called before the first frame update
    private void Start()
    {
        StartCoroutine(CoroutineTest());
        IEnumerator CoroutineTest()
        {
            go1.SetActive(false);
            go2.SetActive(false);
            go3.SetActive(false);
            go4.SetActive(false);
           
            int a; // = 0
            a = Random.Range(1, 5);


            NewBehaviourScript _NewBehaviourScript = FindObjectOfType<NewBehaviourScript>();
            _NewBehaviourScript.b = a;

            int c = 0;

            int d = 0; // save current state

            int[] count = new int[] { 0, 0, 0, 0 }; // array
             
            switch (a)
            {  

                case 0:
                    do
                    {
                        a = Random.Range(1, 5);
                    } while (a == d); //// CHANGE !!!


                    Debug.Log(a);

                    if (a == 1) {
                        goto case 1;
                    }
                    else if (a == 2) {
                        goto case 2;
                    }
                    else if (a == 3) {
                        goto case 3;
                    }
                    else if (a == 4)
                    {
                        goto case 4;
                    }
                    else { break; }


                case 1:
                    yield return new WaitForSeconds(4);
                    go1.SetActive(true);
                    go2.SetActive(false);
                    go3.SetActive(false);
                    go4.SetActive(false);

                    yield return new WaitForSeconds(2);

                    go1.SetActive(false);
                    go2.SetActive(false);
                    go3.SetActive(false);
                    go4.SetActive(false);
                    c = 0;
                    _NewBehaviourScript.b = c;

                    d = 1;
                    count[1] = 1;

                    goto case 0;

                case 2:
                    yield return new WaitForSeconds(4);

                    go1.SetActive(false);
                    go2.SetActive(true);
                    go3.SetActive(false);
                    go4.SetActive(false);

                    yield return new WaitForSeconds(2);

                    go1.SetActive(false);
                    go2.SetActive(false);
                    go3.SetActive(false);
                    go4.SetActive(false);
                    c = 0;
                    _NewBehaviourScript.b = c;

                    d = 2;
                    count[2] = 2;
                    goto case 0;

                case 3:
                    yield return new WaitForSeconds(4);

                    go1.SetActive(false);
                    go2.SetActive(false);
                    go3.SetActive(true);
                    go4.SetActive(false);

                    yield return new WaitForSeconds(2);

                    go1.SetActive(false);
                    go2.SetActive(false);
                    go3.SetActive(false);
                    go4.SetActive(false);
                    c = 0;
                    _NewBehaviourScript.b = c;

                    d = 3;
                    count[3] = 3;
                    goto case 0;

                case 4:
                    yield return new WaitForSeconds(4);

                    go1.SetActive(false);
                    go2.SetActive(false);
                    go3.SetActive(false);
                    go4.SetActive(true);

                    yield return new WaitForSeconds(2);

                    go1.SetActive(false);
                    go2.SetActive(false);
                    go3.SetActive(false);
                    go4.SetActive(false);
                    c = 0;
                    _NewBehaviourScript.b = c;

                    d = 4;
                    count[4] = 4;
                    goto case 0;

            }
            Debug.Log(a);
        }

    // Update is called once per frame
    void Update()
    {}


        //if (Input.GetKeyDown(KeyCode.F))
        //{


        //}



        /*int[] array;
        array = new int[4];

        array[0] = 1;
        array[1] = 2;
        array[2] = 3;
        array[3] = 4;*/



        //if (a == 1)
        //{


        // }

        /* if (a == 2)
         {
             go1.SetActive(false);
             go2.SetActive(true);
             go3.SetActive(false);
             go4.SetActive(false);
         }


         if (a == 3)
         {
             go1.SetActive(false);
             go2.SetActive(false);
             go3.SetActive(true);
             go4.SetActive(false);
         }

         if (a == 4)
         {
             go1.SetActive(false);
             go2.SetActive(false);
             go3.SetActive(false);
             go4.SetActive(true);
         }*/


    }
    /*void Invoke()
    {
        a = Random.Range(1, 5);

    }*/
}      /*if (a == 1)
            {
                go1.SetActive(true);
                go2.SetActive(false);
                go3.SetActive(false);
                go4.SetActive(false);

            }
            if (a == 2)
            {
                go1.SetActive(false);
                go2.SetActive(true);
                go3.SetActive(false);
                go4.SetActive(false);
            }

            if (a == 3)
            {
                go1.SetActive(false);
                go2.SetActive(false);
                go3.SetActive(true);
                go4.SetActive(false);
            }

            if (a == 4)
            {
                go1.SetActive(false);
                go2.SetActive(false);
                go3.SetActive(false);
                go4.SetActive(true);
            }

        }
                InvokeRepeating("Invoke", 1, 1 / 2f);

            void Invoke()
            {
                int a = Random.Range(1, 4);
            }


    } */

