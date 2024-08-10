using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagement : MonoBehaviour
{
    PoolManager poolManager; //プールマネージャーのインスタンス
    float Timer;
    void Start()
    {
        Timer = 0;
        poolManager = FindObjectOfType<PoolManager>(); //プールマネージャーのインスタンスの取得
        poolManager.GetPooledObject(); //これを呼び出すことで障害物が生成される
    }

    void Update()
    {
        Timer += Time.deltaTime;

        if (Timer > 0.5)
        {
            Timer = 0;
            poolManager.GetPooledObject(); //これを呼び出すことで障害物が生成される
        }
    }
}
