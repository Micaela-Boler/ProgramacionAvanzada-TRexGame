using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor : MonoBehaviour
{
    float offsetX = 21.16f;
    public float floorPosition;
    public float floorSpeed;

    
    void Update()
    {
        transform.position -= new Vector3(floorSpeed * Time.deltaTime, 0, 0); 

        if (transform.position.x <= -offsetX)
            transform.position = new Vector3(floorPosition, transform.position.y, 0); 
        
    }
}
