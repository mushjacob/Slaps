using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Diagnostics;
using System.Threading;
using Watch;
using System;

public class CPU_RH_RANDOM : MonoBehaviour
{
    GameObject leftHand;
    Animator lhand;
    int howManyHands;
    float howFast;
    Player playerInstance;
    GameObject thePlayer;
    
    public MYTimer time = new MYTimer();
    System.Random myrandom = new System.Random();
    int randomNumber;
    Animator move;

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
        leftHand = GameObject.Find("CPU_LH");
        lhand = leftHand.GetComponent<Animator>();
        thePlayer = GameObject.Find("Player_LH2");
        playerInstance = thePlayer.GetComponent<Player>();
        move = GetComponent<Animator>();
        randomNumber = myrandom.Next(0, 5000);
        howManyHands = UnityEngine.Random.Range(0, 3);
        howFast = UnityEngine.Random.Range(0.3f, 0.7f);
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
            runIt(0, howManyHands, howFast);
            randomNumber = myrandom.Next(0, 5000);
            howManyHands = UnityEngine.Random.Range(0, 3);
            howFast = UnityEngine.Random.Range(0.3f, 0.7f);
            startTime = Time.time * 1000;

        }





        if (((Time.time * (float)1000) - startTime) >= (float)randomNumber && check == 0)
        {

            runIt(1, howManyHands, howFast);
            if (win == 0)
            {
                startTime2 = Time.time * (float)1000;
            }

            if (win > 0 && ((Time.time * (float)1000) - startTime2) >= 500)
            {
                runIt(0, howManyHands, howFast);
                check++;
                playerInstance.output = Color.green;
            }

            if (playerNum == 1)
            {
                restart++;
                runIt(0, howManyHands, howFast);
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



    void runIt(int type, int hands, float fast)
    {
        move.speed = fast;
        lhand.speed = fast;
        //back to static
        if(type == 0)
        {
            //just RH
            if(hands == 0)
            {
                move.Play("CPU_RH_Take2");
            }

            //just LH
            if(hands == 1)
            {
                lhand.Play("CPU_LH_Take2");
            }

            //both hands
            if(hands == 2)
            {
                move.Play("CPU_RH_Take2");
                lhand.Play("CPU_LH_Take2");
            }
        }

        
        //move in
        if(type == 1)
        {

            //just RH
            if (hands == 0)
            {
                move.Play("CPU_RH_Take1");
            }

            //just LH
            if (hands == 1)
            {
                lhand.Play("CPU_LH_Take1");
            }

            //both hands
            if (hands == 2)
            {
                move.Play("CPU_RH_Take1");
                lhand.Play("CPU_LH_Take1");
            }
        }
    }


}
