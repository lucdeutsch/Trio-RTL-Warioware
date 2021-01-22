using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace RadioRTL
{
    namespace EatingContest
    {
        public class EatAnimation : MonoBehaviour
        {
            public Sprite pirateBase;
            public Sprite pirateEat;
            public bool isEating;
            // Start is called before the first frame update
            void Start()
            {

            }

            // Update is called once per frame
            void Update()
            {
                isEating = FindObjectOfType<PlayerController>().isEating;
                if (isEating)
                {
                    gameObject.GetComponent<SpriteRenderer>().sprite = pirateEat;

                }
                else
                {
                    gameObject.GetComponent<SpriteRenderer>().sprite = pirateBase;
                }
            }
        }
    }
}

