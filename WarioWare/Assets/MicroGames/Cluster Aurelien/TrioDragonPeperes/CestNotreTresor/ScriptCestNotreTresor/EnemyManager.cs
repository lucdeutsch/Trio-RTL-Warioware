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
            public GameObject showInput;

            public GameObject enemy;
            public GameObject lostScreen;

            [Space]
            [Header("Lieux de spawns pour les enemies")]
            public GameObject spot1;
            public GameObject spot2;
            public GameObject spot3;

            private EnemyController enemyController;

            TimedBehaviour timedBehaviour;

            public bool playerLost;

            public override void Start()
            {
                base.Start(); //Do not erase this line!
                enemyController = FindObjectOfType<EnemyController>();
            }

            //FixedUpdate is called on a fixed time.
            public override void FixedUpdate()
            {
                base.FixedUpdate(); //Do not erase this line!
            }

            public void Update()
            {
                if (playerLost)
                {
                    lostScreen.SetActive(true);
                    //on arrete le temps
                    
                }
            }

            //TimedUpdate is called once every tick.
            public override void TimedUpdate()
            {
                //base.TimedUpdate();

                #region EasyMode

                if(currentDifficulty == Difficulty.EASY)
                {
                    if (Tick == 1)
                    {
                        showInput.SetActive(true);
                    }

                    if (Tick == 3)
                    {
                        Destroy(showInput);
                        Instantiate(enemy, spot2.transform);
                    }                  

                    if (Tick == 5)
                    {
                        Destroy(showInput);
                        Instantiate(enemy, spot2.transform);
                    }


                    if (Tick == 7)
                        Debug.Log("la poupe du bateau apparait + end of scrolling");

                    if (Tick == 8)
                    {
                        if (playerLost)
                        {
                            YouLost();
                        }
                        else
                        {
                            Testing.Manager.Instance.Result(true);
                        }
                        
                    }
                }
                    
                #endregion

                #region MediumMode

                if(currentDifficulty == Difficulty.MEDIUM)
                {
                    if (Tick == 1)
                    {
                        showInput.SetActive(true);
                        Debug.Log("audio: COME BACK HERE");
                    }
                        

                    if (Tick == 2)
                    {
                        Instantiate(enemy, spot2.transform);
                    }

                    if (Tick == 3)
                    {
                        Destroy(showInput);
                        Instantiate(enemy, spot3.transform);
                    }

                    if (Tick == 5)
                    {
                        Instantiate(enemy, spot1.transform);
                    }

                    if (Tick == 7)
                    {
                        Debug.Log("la poupe du bateau apparait + end of scrolling");
                    }
                        

                    if (Tick == 8)
                    {
                        if (playerLost)
                        {
                            YouLost();
                        }
                        else
                        {
                            Testing.Manager.Instance.Result(true);
                        }
                    }
                }
                #endregion

                #region HardMode

                if(currentDifficulty == Difficulty.HARD)
                {
                    if (Tick == 1)
                        Debug.Log("audio: COME BACK HERE");

                    if (Tick == 2)
                    {
                        Instantiate(enemy, spot1.transform);
                    }

                    if(Tick == 3)
                    {
                        Instantiate(enemy, spot3.transform);
                    }

                    if (Tick == 5)
                    {
                        Instantiate(enemy, spot2.transform);

                    }


                    if (Tick == 7)
                    {
                        Debug.Log("la poupe du bateau apparait + end of scrolling");
                    }

                    if (Tick == 8)
                    {
                        if (playerLost)
                        {
                            YouLost();
                        }
                        else
                        {
                            Testing.Manager.Instance.Result(true);
                        }
                    }
                }
                #endregion
            }

            public void YouLost()
            {
                Testing.Manager.Instance.Result(false);              
            }           
        }
    }
}