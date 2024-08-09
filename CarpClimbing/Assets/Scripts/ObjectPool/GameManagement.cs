using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagement : MonoBehaviour
{
    PoolManager poolManager; //�v�[���}�l�[�W���[�̃C���X�^���X
    float Timer;
    void Start()
    {
        Timer = 0;
        poolManager = FindObjectOfType<PoolManager>(); //�v�[���}�l�[�W���[�̃C���X�^���X�̎擾
        poolManager.GetPooledObject(); //������Ăяo�����Ƃŏ�Q�������������
    }

    void Update()
    {
        Timer += Time.deltaTime;

        if (Timer > 0.5)
        {
            Timer = 0;
            poolManager.GetPooledObject(); //������Ăяo�����Ƃŏ�Q�������������
        }
    }
}
