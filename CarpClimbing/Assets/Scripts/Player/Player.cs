using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Vector3 screenPoint;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {





    }

    void OnMouseDrag()
    {
        screenPoint = Camera.main.WorldToScreenPoint(transform.position);

        float screenX = Input.mousePosition.x;
        float screenY = Input.mousePosition.y;
        float screenZ = screenPoint.z;

        Vector3 currentScreenPoint = new Vector3(screenX, 240f, screenZ);
        if (280f > currentScreenPoint.x)
        {
            currentScreenPoint = new Vector3(280f, 240f, screenZ);
        }
        else if (currentScreenPoint.x > 1300f)
        {
            currentScreenPoint = new Vector3(1300f, 240f, screenZ);
        }

        

        Vector3 currentPosition = Camera.main.ScreenToWorldPoint(currentScreenPoint);
        transform.position = currentPosition;

    }



}
