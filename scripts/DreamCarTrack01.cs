﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DreamCarTrack01 : MonoBehaviour
{


    //GameObject vars init
    public GameObject TheMarker;
    public GameObject Mark00;
    public GameObject Mark01;
    public GameObject Mark02;
    public GameObject Mark03;
    public GameObject Mark04;
    public GameObject Mark05;
    public GameObject Mark06;
    public GameObject Mark07;
    public GameObject Mark08;
    public GameObject Mark09;
    public GameObject Mark10;
    public GameObject Mark11;
    public GameObject Mark12;
    public GameObject Mark13;
    public GameObject Mark14;
    public GameObject Mark15;
    public GameObject Mark16;
    public GameObject Mark17;
    public GameObject Mark18;
    public GameObject Mark19;
    public GameObject Mark20;
    public GameObject Mark21;
    public GameObject Mark22;
    public GameObject Mark23;
    public GameObject Mark24;
    public GameObject Mark25;
    public GameObject Mark26;
    public GameObject Mark27;
    public GameObject Mark28;
    public GameObject Mark29;


    public int MarkTracker;


    //
    // Update is called once per frame
    void Update()
    {
        //Monitor number of marktracker
        //make position = to markxx;

        ///FIRST 6

        if (MarkTracker == 0) //Tracker will go to mark00 positions.

        {
            TheMarker.transform.position = Mark00.transform.position;

        }

        if (MarkTracker == 1) //Tracker will go to mark00 positions.

        {
            TheMarker.transform.position = Mark01.transform.position;

        }

        if (MarkTracker == 2) //Tracker will go to mark00 positions.

        {
            TheMarker.transform.position = Mark02.transform.position;

        }

        if (MarkTracker == 3) //Tracker will go to mark00 positions.

        {
            TheMarker.transform.position = Mark03.transform.position;

        }

        if (MarkTracker == 4) //Tracker will go to mark00 positions.

        {
            TheMarker.transform.position = Mark04.transform.position;

        }

        if (MarkTracker == 5) //Tracker will go to mark00 positions.

        {
            TheMarker.transform.position = Mark05.transform.position;

        }


        ///SECOND 6
        ///

        if (MarkTracker == 6) //Tracker will go to mark00 positions.

        {
            TheMarker.transform.position = Mark06.transform.position;

        }

        if (MarkTracker == 7) //Tracker will go to mark00 positions.

        {
            TheMarker.transform.position = Mark07.transform.position;

        }

        if (MarkTracker == 8) //Tracker will go to mark00 positions.

        {
            TheMarker.transform.position = Mark08.transform.position;

        }

        if (MarkTracker == 9) //Tracker will go to mark00 positions.

        {
            TheMarker.transform.position = Mark09.transform.position;

        }

        if (MarkTracker == 10) //Tracker will go to mark00 positions.

        {
            TheMarker.transform.position = Mark10.transform.position;

        }

        if (MarkTracker == 11) //Tracker will go to mark00 positions.

        {
            TheMarker.transform.position = Mark11.transform.position;

        }

        ///THIRD 6

        if (MarkTracker == 12) //Tracker will go to mark00 positions.

        {
            TheMarker.transform.position = Mark12.transform.position;

        }

        if (MarkTracker == 13) //Tracker will go to mark00 positions.

        {
            TheMarker.transform.position = Mark13.transform.position;

        }

        if (MarkTracker == 14) //Tracker will go to mark00 positions.

        {
            TheMarker.transform.position = Mark14.transform.position;

        }

        if (MarkTracker == 15) //Tracker will go to mark00 positions.

        {
            TheMarker.transform.position = Mark15.transform.position;

        }

        if (MarkTracker == 16) //Tracker will go to mark00 positions.

        {
            TheMarker.transform.position = Mark16.transform.position;

        }

        if (MarkTracker == 17) //Tracker will go to mark00 positions.

        {
            TheMarker.transform.position = Mark17.transform.position;

        }

        ///FOURTH 6



        if (MarkTracker == 18) //Tracker will go to mark00 positions.

        {
            TheMarker.transform.position = Mark18.transform.position;

        }

        if (MarkTracker == 19) //Tracker will go to mark00 positions.

        {
            TheMarker.transform.position = Mark19.transform.position;

        }

        if (MarkTracker == 20) //Tracker will go to mark00 positions.

        {
            TheMarker.transform.position = Mark20.transform.position;

        }

        if (MarkTracker == 21) //Tracker will go to mark00 positions.

        {
            TheMarker.transform.position = Mark21.transform.position;

        }

        if (MarkTracker == 22) //Tracker will go to mark00 positions.

        {
            TheMarker.transform.position = Mark22.transform.position;

        }

        if (MarkTracker == 23) //Tracker will go to mark00 positions.

        {
            TheMarker.transform.position = Mark23.transform.position;

        }

        //FIFTH 6


        if (MarkTracker == 24) //Tracker will go to mark00 positions.

        {
            TheMarker.transform.position = Mark24.transform.position;

        }

        if (MarkTracker == 25) //Tracker will go to mark00 positions.

        {
            TheMarker.transform.position = Mark15.transform.position;

        }

        if (MarkTracker == 26) //Tracker will go to mark00 positions.

        {
            TheMarker.transform.position = Mark26.transform.position;

        }

        if (MarkTracker == 27) //Tracker will go to mark00 positions.

        {
            TheMarker.transform.position = Mark27.transform.position;

        }

        if (MarkTracker == 28) //Tracker will go to mark00 positions.

        {
            TheMarker.transform.position = Mark28.transform.position;

        }

        if (MarkTracker == 29) //Tracker will go to mark00 positions.

        {
            TheMarker.transform.position = Mark29.transform.position;

        }


    }


    IEnumerator OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "DreamCar01")
        {
            this.GetComponent<BoxCollider>().enabled = false;
            MarkTracker += 1;
            if (MarkTracker == 30)
            {
                MarkTracker = 0;
            }
            yield return new WaitForSeconds(1);
            this.GetComponent<BoxCollider>().enabled = true;
        }
    }

}
