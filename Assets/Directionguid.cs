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
    int a;

    // Start is called before the first frame update
    private void Start()
    {
        InvokeRepeating("Invoke", 1, 1 / 2f);


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            StartCoroutine(CoroutineTest());

        }


        IEnumerator CoroutineTest()
        {
            go1.SetActive(false);
            go2.SetActive(false);
            go3.SetActive(false);
            go4.SetActive(false);

    


            yield return new WaitForSeconds(3);
            /*int[] array;
            array = new int[4];

            array[0] = 1;
            array[1] = 2;
            array[2] = 3;
            array[3] = 4;*/



            //if (a == 1)
            //{
                go1.SetActive(true);
                go2.SetActive(false);
                go3.SetActive(false);
                go4.SetActive(false);

                yield return new WaitForSeconds(3);

                go1.SetActive(false);
                go2.SetActive(false);
                go3.SetActive(false);
                go4.SetActive(false);

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

