using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CPU_LH : MonoBehaviour
{

    Animator move;
    Animation reverse;
    // Use this for initialization
    void Start()
    {
        move = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown("1"))
        {
            move.Play("CPU_LH_Take1");

        }


        if (Input.GetKeyDown("2"))
        {
            move.Play("CPU_LH_Take2");
        }
        /*        if (hello == 1)
            {
                reverse["hand"].speed = -1;
                reverse["hand"].time = reverse["hand"].length;
                reverse.Play("hand");
            }*/
    }
}
