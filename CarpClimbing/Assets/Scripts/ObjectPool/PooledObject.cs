using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

public class PooledObject : MonoBehaviour
{
    private PoolManager pool;
    public PoolManager Pool { get => pool; set => pool = value; }
    public float speed = 10;

    //int addSpeedCount = 40;
    public void Release()
    {
        pool.ReturnToPool(this);
    }


    private void Update()
    {
        this.transform.position += new Vector3(0, -speed * Time.deltaTime, 0);
    }

    //‰æ–ÊŠO‚Éo‚½‚Ìˆ—
    private void OnBecameInvisible()
    {
        pool.ReturnToPool(this);
    }

}
