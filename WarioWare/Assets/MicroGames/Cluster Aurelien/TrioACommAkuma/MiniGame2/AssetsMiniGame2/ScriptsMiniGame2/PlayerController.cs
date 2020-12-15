﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace TrioName
{
    namespace MiniGameName
    {
        /// <summary>
        /// Simon PICARDAT
        /// </summary>
        public class PlayerController : MonoBehaviour
        {
            public Rigidbody2D anchorRb;
            public float playerForce;
            public float cannonMass;
            [HideInInspector]public int soundNum;

            public AudioSource squeak1;
            public AudioSource squeak2;


            private void Start()
            {
                anchorRb.gravityScale = cannonMass;
            }
            void Update()
            {
                if (Input.GetButtonDown("A_Button"))
                {

                    anchorRb.velocity = Vector2.up * playerForce;
                    Debug.Log(anchorRb.velocity);
                    soundNum = Random.Range(1, 2);
                    switch (soundNum) 
                    {
                        case 1:
                            squeak1.Play(0);
                            break;
                        case 2:
                            squeak2.Play(0);
                            break;
                    }
                }
            }
            
        }
    }
}
