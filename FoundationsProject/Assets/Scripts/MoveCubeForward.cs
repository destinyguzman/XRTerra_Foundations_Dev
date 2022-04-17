using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCubeForward : MonoBehaviour
{
    public float speed = 1;
    //public float rotate = 1;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + transform.forward * Time.deltaTime * speed;
        //attempted rotation code that didn't work upon trying to combine it with forward movement: transform.Rotate(0, rotate * Time.deltaTime, 0, Space.Self);
        

    }
}
