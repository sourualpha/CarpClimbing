using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    PoolManager poolManager;
    float Timer;
    public float GameTime;
    // Start is called before the first frame update
    void Start()
    {
        Timer = 0;
        GameTime = -4;
        poolManager = FindObjectOfType<PoolManager>();

    }

    // Update is called once per frame
    void Update()
    {
        GameTime += Time.deltaTime;

        if (GameTime > 0)
        {
            Timer += Time.deltaTime;

            if (Timer > 2)
            {
                Timer = 0;

                poolManager.GetPooledObject();
            }

        }

    }
}
