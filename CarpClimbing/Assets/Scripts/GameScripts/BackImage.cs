using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackImage : MonoBehaviour
{
    public float moveSpeed = 0.5f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, -moveSpeed * Time.deltaTime, 0);

        // ‹«ŠEü‚ğ’´‚¦‚½‚ç
        if (transform.position.y < -10f)
        {
            transform.position = new Vector3(0, 10.176f, 0);
        }
    }
}
