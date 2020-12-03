using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RadioRTL
{
    namespace CeremonieDeThe
    {

        /// <summary>
        /// Riwan HERVOUET
        /// </summary>

        public class TeaPotController : MonoBehaviour
        {

            //1- Initialisation des variables
            private Rigidbody2D teaPotRigidBody;
            public float teaPotSpeed;
            public Vector2 movement;


            //2- Création du Game Object
            void Start()
            {

                gameObject.transform.Translate(0.0f, 0.0f, 0.0f);
                teaPotRigidBody = gameObject.GetComponent<Rigidbody2D>() as Rigidbody2D;
                //teaPotRigidBody.bodyType = RigidbodyType2D.Kinematic;

            }

            //3- Void Update
            void FixedUpdate()
            {

                float moveHorizontal = Input.GetAxis("Left_Joystick_X");

                float moveVertical = Input.GetAxis("Left_Joystick_Y");

                if (moveHorizontal > 0.1f || moveVertical > 0.1f)
                {

                    movement = new Vector2(moveHorizontal, -moveVertical);

                    teaPotRigidBody.AddForce(movement * teaPotSpeed);

                }
                else
                {

                    movement = new Vector2(0.0f, 0.0f);

                    teaPotRigidBody.AddForce(movement * teaPotSpeed);

                }
            }
        }

    }
}

