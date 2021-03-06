﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Testing;

namespace RadioRTL
{
    /// <summary>
    /// Théo Valet
    /// </summary>

    namespace CrabGolf
    {
        public class DifficultyManager : TimedBehaviour
        {
            public CrabParrotBehavior crabParrotBehavior;
            public NormalCrabBehaviour normalCrabBehaviour;
            public float easySpeed;
            public float mediumSpeed;
            public float hardSpeed;
            public int easyCP;
            public int mediumCP;
            public int hardCP;
            public override void Start()
            {
                base.Start();

                switch (currentDifficulty)
                {
                    case Difficulty.EASY:
                        //insérer la logique quand le jeu est facile
                        normalCrabBehaviour.speed = easySpeed;
                        crabParrotBehavior.speed = easySpeed;
                        FindObjectOfType<AudioManager>().Play("Musique 60 BPM");
                        break;
                    case Difficulty.MEDIUM:
                        //insérer la logique quand le jeu est facile
                        normalCrabBehaviour.speed = mediumSpeed;
                        crabParrotBehavior.speed = mediumSpeed;
                        FindObjectOfType<AudioManager>().Play("Musique 90 BPM");
                        break;
                    case Difficulty.HARD:
                        //insérer la logique quand le jeu est facile
                        normalCrabBehaviour.speed = hardSpeed;
                        crabParrotBehavior.speed = hardSpeed;
                        FindObjectOfType<AudioManager>().Play("Musique 120 BPM");
                        break;
                }
            }
        }
    }
}
