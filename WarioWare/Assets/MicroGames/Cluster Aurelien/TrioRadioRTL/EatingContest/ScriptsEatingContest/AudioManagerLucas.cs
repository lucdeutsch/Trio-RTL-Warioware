using UnityEngine.Audio;
using UnityEngine;
using System;
using Testing;


namespace RadioRTL
{
    /// <summary>
    /// DEUTSCHMANN Lucas
    /// </summary>

    namespace EatingContest
    {
        public class AudioManagerLucas : MonoBehaviour
        {
            public SoundsLucas[] sounds;
            public AudioSource gestionSon;

            private void Awake()
            {
                foreach (SoundsLucas s in sounds)
                {
                    s.source = gameObject.AddComponent<AudioSource>();
                    s.source.clip = s.clip;

                    s.source.volume = s.volume;
                    s.source.pitch = s.pitch;
                    s.source.loop = s.loop;
                }
            }
            public void Play(string name)
            {
                SoundsLucas s = Array.Find(sounds, sound => sound.name == name);
                s.source.Play();
                gestionSon.clip = s.source.clip;
            }
        }
    }
}

