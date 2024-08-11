using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    PoolManager poolManager;
    private float Timer;
    public float GameTime;
    public float CreatTimerArea = 1.5f;
    private float CreatTimerAreaCount = 5f;
    // Start is called before the first frame update
    void Start()
    {
        Timer = 0;
        GameTime = -2;
        poolManager = FindObjectOfType<PoolManager>();
    }

    // Update is called once per frame
    void Update()
    {
        GameTime += Time.deltaTime;

        if (GameTime > 0)
        {
            Timer += Time.deltaTime;

            if (Timer > CreatTimerArea)
            {
                Timer = 0;
                poolManager.GetPooledObject();

            }

            if (GameTime > 10 + CreatTimerAreaCount && CreatTimerArea > 0.5f)
            {
                CreatTimerAreaCount += 5;
                CreatTimerArea -= 0.1f;
            }
        }
    }

    public void TitleButtonClic()
    {
        SceneManager.LoadScene("Title");
    }


}
