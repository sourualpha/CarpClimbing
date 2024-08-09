using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Vector3 screenPoint;

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
        if(210f > currentScreenPoint.x)
        {
            currentScreenPoint = new Vector3(210f, 240f, screenZ);
        }
        else if(currentScreenPoint.x > 870f)
        {
            currentScreenPoint = new Vector3(870f, 240f, screenZ);
        }



        Vector3 currentPosition = Camera.main.ScreenToWorldPoint(currentScreenPoint);
        transform.position = currentPosition;

    }



}
