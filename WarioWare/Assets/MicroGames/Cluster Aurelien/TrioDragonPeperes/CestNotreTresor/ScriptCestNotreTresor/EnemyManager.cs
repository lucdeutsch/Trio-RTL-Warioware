﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Dragons_Peperes
{
    namespace CestNotreTresor
    {
        /// <summary>
        /// Mael Ricou
        /// </summary>

        public class EnemyManager : TimedBehaviour
        {

            public GameObject enemy;

            [Space]
            [Header("Lieux de spawns pour les enemies")]
            public GameObject spot1;
            public GameObject spot2;
            public GameObject spot3;

            TimedBehaviour timedBehaviour;

            public override void Start()
            {
                base.Start(); //Do not erase this line!


            }

            //FixedUpdate is called on a fixed time.
            public override void FixedUpdate()
            {
                base.FixedUpdate(); //Do not erase this line!

            }

            //TimedUpdate is called once every tick.
            public override void TimedUpdate()
            {
                //base.TimedUpdate();

                #region EasyMode


                if(currentDifficulty == Testing.Manager.Difficulty.EASY)
                {
                    if (Tick == 1)
                        Debug.Log("audio: COME BACK HERE");

                    if (Tick == 2)
                        Instantiate(enemy, spot2.transform);

                    if (Tick == 5)
                        Instantiate(enemy, spot2.transform);

                    if (Tick == 7)
                        Debug.Log("la poupe du bateau apparait + end of scrolling");

                    if (Tick == 8)
                    {
                        Debug.Log("Victoire");
                    }
                }
                    
                #endregion

                #region MediumMode

                if(currentDifficulty == Testing.Manager.Difficulty.MEDIUM)
                {
                    if (Tick == 1)
                        Debug.Log("audio: COME BACK HERE");

                    if (Tick == 2)
                        Instantiate(enemy, spot2.transform);

                    if (Tick == 5)
                        Instantiate(enemy, spot1.transform);
                        Instantiate(enemy, spot3.transform);

                    if (Tick == 7)
                        Debug.Log("la poupe du bateau apparait + end of scrolling");

                    if (Tick == 8)
                    {
                        Debug.Log("Victoire");
                    }
                }
                #endregion

                #region HardMode

                if(currentDifficulty == Testing.Manager.Difficulty.HARD)
                {
                    if (Tick == 1)
                        Debug.Log("audio: COME BACK HERE");

                    if (Tick == 2)
                        Instantiate(enemy, spot1.transform);
                    Instantiate(enemy, spot3.transform);

                    if (Tick == 5)
                        Instantiate(enemy, spot1.transform);
                    Instantiate(enemy, spot3.transform);

                    if (Tick == 7)
                        Debug.Log("la poupe du bateau apparait + end of scrolling");

                    if (Tick == 8)
                    {
                        Debug.Log("Victoire");
                    }
                }
                #endregion
            }
        }
    }
}