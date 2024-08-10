using System.Collections.Generic;
using UnityEngine;

public class PoolManager : MonoBehaviour
{
    [SerializeField] private uint initPoolSize; //�ŏ��ɐ��������
    [SerializeField] private List<PooledObject> objectToPool; //prefab�����郊�X�g


    private List<PooledObject> pool;

    private void Start()
    {
        SetupPool();
    }

    //�v�[���̏�����
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

                //if ()
                /*{

                }*/

                instance.speed = 50;


                pool.Add(instance);
            }
        }
    }

    //�\�����鏈��
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

        //�\������ۂ�X����-2�`2�܂ł̃����_���ɂ��Đ�������
        int randomTransfomIndex = UnityEngine.Random.Range(-2, 2);
        PooledObject nextInstance = pool[randomPoolIndex];
        pool.RemoveAt(randomPoolIndex);

        nextInstance.gameObject.transform.position = new Vector3(randomTransfomIndex, 6, 0); //�\������ۂ̍��W�̐ݒ�
        nextInstance.gameObject.SetActive(true);

        return nextInstance;
    }

    //��\���ɂ��鏈��
    public void ReturnToPool(PooledObject pooledObject)
    {
        pool.Add(pooledObject);
        pooledObject.gameObject.SetActive(false);
    }
}
