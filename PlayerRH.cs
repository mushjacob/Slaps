using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRH : MonoBehaviour
{
    GameObject theScriptObj;
    CPU_RH_RANDOM theScript;
    public int rightHandCol = 0;
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

        if (Input.GetKeyDown("3") || Input.GetKeyDown("2"))
        {
            move.Play("PlayerRH_Take1");

        }


        if (Input.GetKeyUp("3") || Input.GetKeyUp("2"))
        {
            move.Play("PlayerRH_Take2");
        }
        /*        if (hello == 1)
            {
                reverse["hand"].speed = -1;
                reverse["hand"].time = reverse["hand"].length;
                reverse.Play("hand");
            }*/
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "CPU_LH")
        {
            rightHandCol = 1;
        }
    }
}
