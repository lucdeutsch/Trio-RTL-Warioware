using System.Collections;
using System.Collections.Generic;
using UnityEngine.Audio;
using UnityEngine;
using System;
using Testing;

namespace RadioRTL
{
    /// <summary>
    /// Riwan HERVOUET
    /// </summary>

    namespace CeremonieDeThe
    {
        public class Script_SoundManager : MonoBehaviour
        {
            public Script_Sounds [] sounds;
            public AudioSource [] gestionSon;

            private void Awake()
            {
                foreach (Script_Sounds s in sounds)
                {
                    s.source = gameObject.AddComponent<AudioSource>();
                    s.source.clip = s.clip;

                    s.source.volume = s.volume;
                    s.source.pitch = s.pitch;
                    s.source.loop = s.loop;
                }
            }
            public void Play(string name, int index)
            {
                Script_Sounds s = Array.Find(sounds, sound => sound.name == name);
                s.source.Play();
                gestionSon[index].clip = s.source.clip;

                /*Element 0 musique
                 Element 1 Victoire & defaite
                Element 2 eau qui coule
                Element 3 bateau qui tangue
                Element 4 eau qui touche la tasse*/
            }
        }
    }
}