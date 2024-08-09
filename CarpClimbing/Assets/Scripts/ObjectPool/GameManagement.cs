using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagement : MonoBehaviour
{
    PoolManager poolManager;
    float Timer;
    // Start is called before the first frame update
    void Start()
    {
        Timer = 0;
        poolManager = FindObjectOfType<PoolManager>();
        
    }

    // Update is called once per frame
    void Update()
    {
        Timer += Time.deltaTime;

        if (Timer > 5)
        {
            Timer = 0;
            poolManager.GetPooledObject();
        }
    }
}
