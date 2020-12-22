using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Dragons_Peperes
{
    namespace ChasseAuTresor
    {
        /// <summary>
        /// Noé Blanc
        /// </summary>

        public class PlayerController : MonoBehaviour
        {

            private bool canMove;

            public float distance;

            public GameObject treasure;

            private SpriteRenderer spriteRenderer;

            public Sprite upSprite;
            public Sprite downSprite;
            public Sprite leftSprite;
            public Sprite rightSprite;

            // Start is called before the first frame update
            void Start()
            {
                canMove = true;

                distance = 0.8f;

                spriteRenderer = gameObject.GetComponent<SpriteRenderer>();

            }

            private void FixedUpdate()
            {
                if(treasure.GetComponent<WinOrLooseScript>().finished == false)
                {
                    if (Mathf.Abs(Input.GetAxisRaw("Left_Joystick_X")) <= 0.2 && Mathf.Abs(Input.GetAxisRaw("Left_Joystick_Y")) <= 0.2)
                    {
                        canMove = true;
                    }
                }                

                if (canMove == true)
                {
                    if (Mathf.Abs(Input.GetAxisRaw("Left_Joystick_X")) >= 0.95f)
                    {
                        if(Input.GetAxisRaw("Left_Joystick_X") > 0f)
                        {
                            transform.position += new Vector3(distance, 0, 0);
                            spriteRenderer.sprite = rightSprite;
                        }
                        if (Input.GetAxisRaw("Left_Joystick_X") < 0f)
                        {
                            transform.position += new Vector3(-distance, 0, 0);
                            spriteRenderer.sprite = leftSprite;
                        }

                        canMove = false;
                    }
                    if (Mathf.Abs(Input.GetAxisRaw("Left_Joystick_Y")) >= 0.95f)
                    {
                        if (Input.GetAxisRaw("Left_Joystick_Y") > 0f)
                        {
                            transform.position += new Vector3(0, distance, 0);
                            spriteRenderer.sprite = upSprite;
                        }
                        if (Input.GetAxisRaw("Left_Joystick_Y") < 0f)
                        {
                            transform.position += new Vector3(0, -distance, 0);
                            spriteRenderer.sprite = downSprite;
                        }
                        canMove = false;
                    }
                }

                if (treasure.GetComponent<WinOrLooseScript>().finished == true)
                {
                    canMove = false;
                }
            }
        }
    }
}
