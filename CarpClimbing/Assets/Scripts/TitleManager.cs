using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleManager : MonoBehaviour
{
    [SerializeField] GameManager gameManager;

    public float moveSpeed = 0.5f;
    public void PushStartButton()
    {
        if (0f < gameManager.GameTime)
        {
            transform.position = new Vector3(0, 10f, 0);
        }
        SceneManager.LoadScene("GameScene");
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
