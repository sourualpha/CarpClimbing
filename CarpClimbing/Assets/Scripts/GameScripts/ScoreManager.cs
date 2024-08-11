using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{

    [SerializeField] GameManager gameManager;
    [SerializeField] Text scoreText;
    [SerializeField] Text lastScoreText;
    [SerializeField] Player player;
    [SerializeField] Image reaultImage;
    [SerializeField] Sprite resultSprite1;
    [SerializeField] Sprite resultSprite2;

    double score = 0;
    public int gameScore;

    // Update is called once per frame
    void Update()
    {
        if (gameManager.GameTime >= 0 && player.HP > 0)
        {
            score = gameManager.GameTime * 10;
            gameScore = (int)score;
        }
        
        if(player.HP <= 0)
        {
            gameManager.enabled = false;
        }

        scoreText.text = gameScore.ToString() + "m";
        lastScoreText.text = gameScore.ToString() + "m “o‚Á‚½!";

        if(score > 1000) 
        { 
            reaultImage.sprite = resultSprite2;
        }
        else if(score > 500)
        {
            reaultImage.sprite = resultSprite1;
        }

    }
}
