using System.Collections.Generic;
using UnityEngine;

public class PoolManager : MonoBehaviour
{
    [SerializeField] private uint initPoolSize;
    [SerializeField] private List<PooledObject> objectToPool;

    private List<PooledObject> pool;

    private void Start()
    {
        SetupPool();
    }

    private void SetupPool()
    {
        pool = new List<PooledObject>();

        // objectToPool�ɂ���S�Ẵv���n�u���v�[���ɒǉ�
        for (int i = 0; i < objectToPool.Count; i++)
        {
            for (int j = 0; j < initPoolSize; j++)
            {
                PooledObject instance = Instantiate(objectToPool[i]);
                instance.Pool = this;
                instance.gameObject.SetActive(false);
                pool.Add(instance);
            }
        }
    }

    public PooledObject GetPooledObject()
    {
        if (pool.Count == 0)
        {
            // �v�[������̏ꍇ�A�V�����I�u�W�F�N�g�������_���ɐ���
            int randomIndex = UnityEngine.Random.Range(0, objectToPool.Count);
            PooledObject newInstance = Instantiate(objectToPool[randomIndex]);
            newInstance.Pool = this;

            return newInstance;
        }

        // �����_���Ƀv�[������擾
        int randomPoolIndex = UnityEngine.Random.Range(0, pool.Count);
        int randomTransfomIndex = UnityEngine.Random.Range(-2, 2);
        PooledObject nextInstance = pool[randomPoolIndex];
        pool.RemoveAt(randomPoolIndex);

        nextInstance.gameObject.transform.position = new Vector3(randomTransfomIndex, 6, 0);
        nextInstance.gameObject.SetActive(true);

        return nextInstance;
    }

    public void ReturnToPool(PooledObject pooledObject)
    {
        pool.Add(pooledObject);
        pooledObject.gameObject.SetActive(false);
    }
}
