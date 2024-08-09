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

        // 境界線を超えたら
        if (transform.position.y < -10.003202f)
        {
            transform.position = new Vector3(0, 11.31912f, 0);
        }
    }
}
