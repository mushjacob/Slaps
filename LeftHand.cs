using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftHand : MonoBehaviour
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
            move.Play("hand2");

        }


        if (Input.GetKeyDown("2"))
        {
            move.Play("Take 001");
        }
        /*        if (hello == 1)
            {
                reverse["hand"].speed = -1;
                reverse["hand"].time = reverse["hand"].length;
                reverse.Play("hand");
            }*/
    }
}
