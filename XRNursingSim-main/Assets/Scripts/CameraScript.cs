using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    
    public float Speed = 2.0f;

   

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
             
            transform.eulerAngles += Speed * new Vector3(0, -Input.GetAxis("Mouse X"), 0) ; 
        }
      
    }
}
