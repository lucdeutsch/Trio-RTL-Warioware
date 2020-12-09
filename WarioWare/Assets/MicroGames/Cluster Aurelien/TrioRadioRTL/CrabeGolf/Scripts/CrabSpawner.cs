using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RadioRTL
{
    /// <summary>
    /// Théo Valet
    /// </summary>
namespace CrabeGolf
    {
        public class CrabSpawner : TimedBehaviour
        {
            public GameObject crab;
            public GameObject crabParrot;
            public override void Start()
            {
                base.Start(); //Do not erase this line!

            }

            //FixedUpdate is called on a fixed time.
            public override void FixedUpdate()
            {
                base.FixedUpdate(); //Do not erase this line!

            }

            //TimedUpdate is called once every tick.
            public override void TimedUpdate()
            {
                if (Tick == 2)
                {
                    Instantiate(crab,new Vector3(-8, -3, 0),Quaternion.identity);
                }
                if (Tick == 3)
                {
                    Instantiate(crabParrot, new Vector3(-8, -3, 0), Quaternion.identity);
                }
                if (Tick == 4)
                {
                    Instantiate(crab, new Vector3(-8, -3, 0), Quaternion.identity);
                }
                if (Tick == 5)
                {
                    Instantiate(crabParrot, new Vector3(-8, -3, 0), Quaternion.identity);
                }
            }
        }
      }
}


