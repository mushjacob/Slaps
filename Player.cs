using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    // Use this for initialization
    APpear enemyInstance;
    Renderer thisPlayer;
    int f;
    GameObject thePlayer;
    int check;
    public int check2 = 0;
    int clicked;
    public Color output;

    void Start()
    {

        thePlayer = GameObject.Find("Cube");
        enemyInstance = thePlayer.GetComponent<APpear>();
        output = Color.white;
        /*enemyInstance = GetComponent<APpear>();*/
        thisPlayer = GetComponent<Renderer>();
        thisPlayer.material.color = Color.white;
    }

    // Update is called once per frame
    void Update()
    {
        f = enemyInstance.win;
        check = enemyInstance.check;

        if (f == 0 || check != 0)
        {
            thisPlayer.material.color = output;
            check2 = 0;
        }

        else if (Input.GetKeyDown(KeyCode.Return))
        {
            check2++;
            output = Color.white;
            thisPlayer.material.color = output;
            enemyInstance.playerNum = 1;
        }

        if (f != 0 && check == 0 && check2 == 0)
        {
            thisPlayer.material.color = Color.red;
        }



    }
}