﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Testing;

namespace RadioRTL
{
    /// <summary>
    /// Théo Valet
    /// </summary>
}
public class NormalCrabBehaviour : MonoBehaviour
{
    private Vector3 target;
    public float speed;
    private Vector3 position;
    public bool isShot;
    bool isFlying;

    void Start()
    {
        target = new Vector3(8, -3, 0);
        position = gameObject.transform.position;
    }

    void Update()
    {
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target, step);

        if (gameObject.transform.position == target)
        { 
            if (!isShot)
            {
                Manager.Instance.Result(false);
            }
            Destroy(gameObject);
        }

        if (isShot)
        {
            if (!isFlying)
            {
                target = new Vector3(Random.Range(-8f, 8f), 3f, 0f);
                isFlying = true;
            }

            speed = 20;
        }
    }
}
