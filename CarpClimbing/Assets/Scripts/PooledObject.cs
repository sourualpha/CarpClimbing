using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

public class PooledObject : MonoBehaviour
{
    private PoolManager pool;
    public PoolManager Pool { get => pool; set => pool = value; }
    private float speed = -3;
    public void Release()
    {
        pool.ReturnToPool(this);
    }

    private void Update()
    {
        this.transform.position += new Vector3(0, speed * Time.deltaTime, 0);
    }

    private void OnBecameInvisible()
    {
        pool.ReturnToPool(this);
    }

}
