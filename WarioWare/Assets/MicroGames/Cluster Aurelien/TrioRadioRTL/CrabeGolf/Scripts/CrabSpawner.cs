using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TrioName
{
    namespace MiniGameName
    {
        public class CrabSpawner : TimedBehaviour
        {
            public GameObject crab;
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
                if (Tick <= 4)
                {
                    Instantiate(crab,new Vector3(-8, -3, 0),Quaternion.identity);
                }
            }
        }
    }
}