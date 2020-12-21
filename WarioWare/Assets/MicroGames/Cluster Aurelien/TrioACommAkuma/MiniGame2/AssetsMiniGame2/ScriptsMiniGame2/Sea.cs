﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Testing;

namespace TrioName
{
    namespace MiniGameName
    {
        /// <summary>
        /// Simon PICARDAT
        /// </summary>
        public class Sea : MonoBehaviour
        {
            public AudioSource plouf;
            public bool loose;

            private void Start()
            {
                plouf = GetComponent<AudioSource>();
            }
            private void OnTriggerEnter2D(Collider2D other)
            {
                if (other.gameObject.tag == "Projectile")
                {
                    plouf.Play(0);
                    Destroy(other);
                }
            }
        }

    }
}
