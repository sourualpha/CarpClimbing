using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

public class PooledObject : MonoBehaviour
{

    [SerializeField] ScoreManager scoreManager;



    private PoolManager pool;
    public PoolManager Pool { get => pool; set => pool = value; }
    public float speed = 10;

    int addSpeedCount = 40;
    public void Release()
    {
        pool.ReturnToPool(this);
    }


    private void Update()
    {
        this.transform.position += new Vector3(0, -speed * Time.deltaTime, 0);

        if(addSpeedCount < scoreManager.gameScore)
        {
            speed -= 1.25f;
            addSpeedCount += 50;
        }
    }

    //‰æ–ÊŠO‚Éo‚½Žž‚Ìˆ—
    private void OnBecameInvisible()
    {
        pool.ReturnToPool(this);
    }

}
