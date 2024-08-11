using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SocialPlatforms.Impl;

public class Highscore : MonoBehaviour
{
    [SerializeField] Text highScoreText;

    ScoreManager scoreManager;

    public int highScore = 0; // �n�C�X�R�A��ێ�

    void Start()
    {
        scoreManager = FindObjectOfType<ScoreManager>();
        highScore = PlayerPrefs.GetInt("SCORE", 0);
    }

    // Update is called once per frame
    public void UpdateScore()
    {
        if (highScore < scoreManager.gameScore)  //�n�C�X�R�A�𒴂����ꍇ�ɍX�V
        {
            highScore = scoreManager.gameScore;

            //"SCORE"���L�[�Ƃ��āA�n�C�X�R�A��ۑ�
            PlayerPrefs.SetInt("SCORE", highScore);
            PlayerPrefs.Save();//�f�B�X�N�ւ̏�������

        }

        highScoreText.text = "�n�C�X�R�A: " + highScore.ToString() + "m";

    }
}
