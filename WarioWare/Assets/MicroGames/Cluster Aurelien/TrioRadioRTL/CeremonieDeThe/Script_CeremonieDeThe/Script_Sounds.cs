﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.Audio;
using UnityEngine;
using Testing;

namespace RadioRTL
{
    /// <summary>
    /// Riwan HERVOUET
    /// </summary>

    namespace CeremonieDeThe
    {
        [System.Serializable]
        public class Script_Sounds
        {
            public string name;

            public AudioClip clip;

            [Range(0f, 1f)]
            public float volume;
            [Range(.1f, 3f)]
            public float pitch;

            public bool loop;

            [HideInInspector]
            public AudioSource source;
        }

    }
}
