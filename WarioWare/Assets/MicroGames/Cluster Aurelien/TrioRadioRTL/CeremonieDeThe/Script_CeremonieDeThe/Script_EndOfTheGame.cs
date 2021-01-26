﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Caps;

namespace RadioRTL
{
    namespace CeremonieDeThe
    {

        /// <summary>
        /// Riwan HERVOUET
        /// </summary>

        public class Script_EndOfTheGame : TimedBehaviour
        {

            //1- Variables
            //1.1- Game Object & Collider
            public Script_PouredTea teaCup;
            public Collider2D teaPotCollider;
            public GameObject fireWorks;

            //1.2- Booléennes & int
            bool cupIsFull;
            int cupQuantity;
			public int waterToVictory;
            bool victoryMusicWasPlayed = false;

            //2- Récupération des donné
            public override void Start()
            {

                victoryMusicWasPlayed = false;

                base.Start(); //Do not erase this line!

                /*switch (currentDifficulty)
                {

                    case (Difficulty.EASY):

                        waterToVictory -= 0;

                        break;

                    case (Difficulty.MEDIUM):

                        waterToVictory -= 6;

                        break;

                    case (Difficulty.HARD):

                        waterToVictory -= 9;

                        break;

                }*/

                switch (bpm)
                {

                    case (60):
                        waterToVictory = 90;
                        FindObjectOfType<Script_SoundManager>().Play("Musique 60", 0);
                        break;

                    case (80):
                        waterToVictory = 81;
                        FindObjectOfType<Script_SoundManager>().Play("Musique 80", 0);
                        break;

                    case (100):
                        waterToVictory = 60;
                        FindObjectOfType<Script_SoundManager>().Play("Musique 100", 0);
                        break;

                    case (120):
                        waterToVictory = 42;
                        FindObjectOfType<Script_SoundManager>().Play("Musique 120", 0);
                        break;

                }

                //2.2- Désactive le particle effect
                fireWorks.SetActive(false);

            }

            //FixedUpdate is called on a fixed time.
            public override void FixedUpdate()
            {
                base.FixedUpdate(); //Do not erase this line!

            }

            //3- TimedUpdate is called once every tick.
            public override void TimedUpdate()
            {
                cupQuantity = teaCup.pouredTea;

                if (cupQuantity >= waterToVictory)
                {

                    FindObjectOfType<Script_SoundManager>().Play("Victoire", 1);
                    victoryMusicWasPlayed = true;
                    fireWorks.SetActive(true);

                }

                //Debug.Log(Tick);

                //3.1- A la fin de la 8 tick
                if (Tick == 8)
                {
                    //Debug.Log("end");

                    cupQuantity = teaCup.pouredTea;

                    //Debug.Log(cupQuantity);

                    //3.1.2- Verfication des conditions
                    if ( cupQuantity >= waterToVictory)
                    {

                        Manager.Instance.Result(true);
                        //print("victoire");

                        FindObjectOfType<Script_SoundManager>().Play("Victoire", 1);
                        victoryMusicWasPlayed = true;
                        fireWorks.SetActive(true);

                    }
                    else
                    {

                        Manager.Instance.Result(false);
                        //Debug.Log("defaite");

                        FindObjectOfType<Script_SoundManager>().Play("Defaite", 1);

                        fireWorks.SetActive(false);

                    }

                    if (victoryMusicWasPlayed == true)
                    {

                        FindObjectOfType<Script_SoundManager>().Stop("Victoire");

                    }

                }

            }
        }
    }
}