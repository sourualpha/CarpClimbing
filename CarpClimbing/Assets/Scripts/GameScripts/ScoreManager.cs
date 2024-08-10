using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{

    [SerializeField] GameManager gameManager;

    double score = 0;
    public int gameScore;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameManager.GameTime >= 0)
        {
            score = gameManager.GameTime * 2.5;
            gameScore = (int)score;
        }

    }
}
