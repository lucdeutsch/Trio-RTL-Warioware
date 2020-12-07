using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// DEUTSCHMANN Lucas
/// </summary>

namespace TrioRadioRTL
{
    namespace EatingContest
    {

        public class PlatesManager : MonoBehaviour
        {
            bool isRotten;
            public PlayerController playerController;

            [Header("Graphs")]

            public SpriteRenderer plate;
            public Sprite goodPlateSpriteEmpty;
            public Sprite goodPlateSprite1;
            public Sprite goodPlateSprite2;
            public Sprite goodPlateSprite3;
            public Sprite goodPlateSprite4;
            public Sprite goodPlateSprite5;
            public Sprite rottenPlateSprite;


            // Start is called before the first frame update
            void Start()
            {
                
                plate = gameObject.GetComponent<SpriteRenderer>();
            }

            // Update is called once per frame
            void Update()
            {
                isRotten = playerController.rottenPlate;

                if (isRotten)
                {
                    plate.sprite = rottenPlateSprite;
                }
                else
                {
                    plate.sprite = goodPlateSpriteEmpty;
                }
                
                
            }
        }
    }
}
