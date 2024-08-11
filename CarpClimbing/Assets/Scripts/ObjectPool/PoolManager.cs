using System.Collections.Generic;
using UnityEngine;

public class PoolManager : MonoBehaviour
{
    [SerializeField] private uint initPoolSize; //最初に生成する個数
    [SerializeField] private List<PooledObject> objectToPool; //prefabを入れるリスト
    [SerializeField] ScoreManager scoreManager;

    private List<PooledObject> pool;
    private float speed = 7;
    private int addSpeedCount = 40;

    private void Start()
    {
        SetupPool();
    }

    //プールの初期化
    private void SetupPool()
    {
        pool = new List<PooledObject>();

        // objectToPoolにある全てのプレハブをプールに追加
        for (int i = 0; i < objectToPool.Count; i++)
        {
            for (int j = 0; j < initPoolSize; j++)
            {
                PooledObject instance = Instantiate(objectToPool[i]);
                instance.Pool = this;
                instance.gameObject.SetActive(false);
                instance.speed = speed;

                pool.Add(instance);
            }
        }
    }

    //表示する処理
    public PooledObject GetPooledObject()
    {
        if (pool.Count == 0)
        {
            // プールが空の場合、新しいオブジェクトをランダムに生成
            int randomIndex = UnityEngine.Random.Range(0, objectToPool.Count);
            PooledObject newInstance = Instantiate(objectToPool[randomIndex]);
            newInstance.Pool = this;

            return newInstance;
        }

        // ランダムにプールから取得
        int randomPoolIndex = UnityEngine.Random.Range(0, pool.Count);

        //表示する際にX軸を-2～2までのランダムにして生成する
        int randomTransfomIndex = UnityEngine.Random.Range(-2, 2);
        PooledObject nextInstance = pool[randomPoolIndex];
        pool.RemoveAt(randomPoolIndex);

        nextInstance.gameObject.transform.position = new Vector3(randomTransfomIndex, 6, 0); //表示する際の座標の設定
        if (addSpeedCount < scoreManager.gameScore)
        {
            if (speed < 25f)
            {
                speed += 0.5f;
            }
            addSpeedCount += 40;
        }
        nextInstance.speed = speed;
        nextInstance.gameObject.SetActive(true);

        return nextInstance;
    }

    //非表示にする処理
    public void ReturnToPool(PooledObject pooledObject)
    {
        pool.Add(pooledObject);
        pooledObject.gameObject.SetActive(false);
    }
}
