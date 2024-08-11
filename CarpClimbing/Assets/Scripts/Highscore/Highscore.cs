using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SocialPlatforms.Impl;

public class Highscore : MonoBehaviour
{
    [SerializeField] Text highScoreText;

    ScoreManager scoreManager;

    public int highScore = 0; // ハイスコアを保持

    void Start()
    {
        scoreManager = FindObjectOfType<ScoreManager>();
        highScore = PlayerPrefs.GetInt("SCORE", 0);
    }

    // Update is called once per frame
    public void UpdateScore()
    {
        if (highScore < scoreManager.gameScore)  //ハイスコアを超えた場合に更新
        {
            highScore = scoreManager.gameScore;

            //"SCORE"をキーとして、ハイスコアを保存
            PlayerPrefs.SetInt("SCORE", highScore);
            PlayerPrefs.Save();//ディスクへの書き込み

        }

        highScoreText.text = "ハイスコア: " + highScore.ToString() + "m";

    }
}
