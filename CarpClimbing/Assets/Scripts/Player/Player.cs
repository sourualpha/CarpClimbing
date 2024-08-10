using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Vector3 screenPoint;

    public int HP = 3;

    float hitTimer = 0;
    bool hit = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (hit == true)
        {
            hitTimer += Time.deltaTime;
        }
        if(hitTimer > 0.5f)
        {
            hitTimer = 0;
            hit = false;
            GetComponent<Renderer>().material.color = new Color32(255, 255, 255, 255);

        }



    }

    void OnMouseDrag()
    {
        screenPoint = Camera.main.WorldToScreenPoint(transform.position);

        float screenX = Input.mousePosition.x;
        //float screenY = Input.mousePosition.y;
        //float screenZ = screenPoint.z;

        Vector3 currentScreenPoint = new Vector3(screenX, 240f, 10f);
        if (280f > currentScreenPoint.x)
        {
            currentScreenPoint = new Vector3(280f, 240f, 10f);
        }
        else if (currentScreenPoint.x > 1300f)
        {
            currentScreenPoint = new Vector3(1300f, 240f, 10f);
        }

        Vector3 currentPosition = Camera.main.ScreenToWorldPoint(currentScreenPoint);
        transform.position = currentPosition;

    }

    void OnTriggerEnter2D(Collider2D c)
    {
        HP -= 1;
        if(HP <= 0)
        {

        }
        hit = true;
        GetComponent<Renderer>().material.color = new Color32(255, 100, 100, 255);
    }



}
