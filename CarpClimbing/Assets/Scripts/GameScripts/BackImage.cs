using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackImage : MonoBehaviour
{
    [SerializeField] GameManager gameManager;

    public float moveSpeed = 0.5f;
    float addSpeedTime = 16f;

    // Update is called once per frame
    void Update()
    {

        if (0f < gameManager.GameTime) 
        {
            transform.position += new Vector3(0, -moveSpeed * Time.deltaTime, 0);

            // ‹«ŠEü‚ð’´‚¦‚½‚ç
            if (transform.position.y <= -20f)
            {
                transform.position = new Vector3(0, 10f, 0);
            }

            if (addSpeedTime < gameManager.GameTime && CompareTag("Waterfall"))
            {
                moveSpeed += 0.05f;
                addSpeedTime += 8f;


            }

        }
        else if (CompareTag("Waterfall"))
        {
            transform.position += new Vector3(0, (-moveSpeed * 0.5f) * Time.deltaTime, 0);
        }

    }
}
