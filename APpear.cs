using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Diagnostics;
using System.Threading;
using Watch;
using System;

public class APpear : MonoBehaviour
{

    Player playerInstance;
    GameObject theEnemy;

    public MYTimer time = new MYTimer();
    System.Random myrandom = new System.Random();
    int randomNumber;


    long y;
    int x = 0;

    long f = 100;



    float startTime;
    float startTime2;
    public int check = 0;
    public int win = 0;
    public int restart = 0;

    public int playerNum;

    void Start()
    {
        theEnemy = GameObject.Find("Sphere");
        playerInstance = theEnemy.GetComponent<Player>();

        randomNumber = myrandom.Next(0, 5000);
        this.gameObject.GetComponent<MeshRenderer>().enabled = false;
        MeshRenderer[] rs = GetComponentsInChildren<MeshRenderer>();
        foreach (MeshRenderer r in rs)
            r.enabled = false;
        //this.gameObject.transform.Find("ChamferBox01").GetComponent<MeshRenderer>().enabled = false;

        startTime = Time.time * 1000;



    }

    void Update()
    {

        /*if (x >= randomNumber)
        {
            Destroy(gameObject);
        }

        x++;*/



        if ((((Time.time * (float)1000) - startTime) >= (float)5000) || restart != 0)
        {
            win = 0;
            check = 0;
            restart = 0;
            playerNum = 0;
            this.gameObject.GetComponent<MeshRenderer>().enabled = false;
            randomNumber = myrandom.Next(0, 5000);
            startTime = Time.time * 1000;

        }





        if (((Time.time * (float)1000) - startTime) >= (float)randomNumber && check == 0)
        {

            this.gameObject.GetComponent<MeshRenderer>().enabled = true;
            if (win == 0)
            {
                startTime2 = Time.time * (float)1000;
            }

            if (win > 0 && ((Time.time * (float)1000) - startTime2) >= 300)
            {
                this.gameObject.GetComponent<MeshRenderer>().enabled = false;
                check++;
                playerInstance.output = Color.green;
            }

            if (playerNum == 1)
            {
                restart++;
                this.gameObject.GetComponent<MeshRenderer>().enabled = false;
                playerInstance.output = Color.white;
                check++;
            }

            win++;
        }


        /*
        if( ((Time.time * (float)1000) - startTime) >= (float)randomNumber)
        {
            startTime2 = Time.time * (float)1000;
            win = 1;
            float newTime = Time.time * (float)1000;
            this.gameObject.GetComponent<MeshRenderer>().enabled = true;
            while ( newTime- startTime2 <= (float)3000)
            {

                
                newTime.
 
                
            }


            this.gameObject.GetComponent<MeshRenderer>().enabled = false;
        }*/
    }



    public int returnWin()
    {
        return win;
    }


}
