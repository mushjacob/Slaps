using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Diagnostics;
using System.Threading;
using System;


namespace Watch
{

    public class MYTimer : Component
    {

        // Use this for initialization
        bool start = false;
        bool stop = true;
        double startTim;
        double elapsedTime;
        double currentms;

        void Start()
        {

            startTim = 0;
            elapsedTime = 0.0;

        }

        // Update is called once per frame
        void Update()
        {

            if (stop == false)
            {
                currentms = (Time.time * 1000.0);
                elapsedTime += currentms - startTim;
            }

        }



        public void stopTime()
        {
            if (start == true && stop == false)
            {
                stop = true;
            }

            else if (start == true && stop == true)
            {
                resetTime();
            }

        }

        public void resetTime()
        {
            start = false;
            stop = true;
            startTim = 0;
            elapsedTime = 0;
        }

        public void startTime()
        {
            start = true;
            stop = false;
            startTim = (Time.time) * 1000;
        }


        public double currentTime()
        {
            return elapsedTime;
        }

    }

}
