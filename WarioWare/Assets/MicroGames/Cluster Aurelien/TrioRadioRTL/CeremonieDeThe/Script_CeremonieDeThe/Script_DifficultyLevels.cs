using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Testing;

namespace RadioRTL
{
    namespace CeremonieDeThe
    {

        /// <summary>
        /// Riwan HERVOUET
        /// </summary>

        public class Script_DifficultyLevels : TimedBehaviour
        {

            //1- Création des variables et récupération des objets
            //1.1- Game Objects
            public GameObject teaCup;
            public GameObject teaPot;

            //1.2- Int
            public int difficultyTeaPotSpeed;
            public int difficultyMouvementTeaCup;

            public override void Start()
            {
                base.Start(); //Do not erase this line!

                //2- écupération des données
                //2.1- Tea Pot
                Script_TeaPotController teaPotController = teaPot.GetComponent<Script_TeaPotController>();
                difficultyTeaPotSpeed = teaPotController.teaPotSpeed;

                //2.2- Tea Cup
                Script_TeaCup teaCupManager = teaCup.GetComponent<Script_TeaCup>();
                difficultyMouvementTeaCup = teaCupManager.mouvementTeaCupX;


                //3- Niveau de difficulté
                switch (currentDifficulty)
                {

                    case Manager.Difficulty.EASY:

                        teaPotController.teaPotSpeed = 30;

                        teaCupManager.mouvementTeaCupX = 2;

                        break;

                    case Manager.Difficulty.MEDIUM:

                        teaPotController.teaPotSpeed = 40;

                        teaCupManager.mouvementTeaCupX = 4;

                        break;

                    case Manager.Difficulty.HARD:

                        teaPotController.teaPotSpeed = 50;

                        teaCupManager.mouvementTeaCupX = 6;

                        break;

                }
            }


            public override void FixedUpdate()
            {
                base.FixedUpdate(); //Do not erase this line!

            }
            public override void TimedUpdate()
            {

            }
        }
    }
}