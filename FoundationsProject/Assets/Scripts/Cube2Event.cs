using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube2Event : MonoBehaviour
{
    public EventManager evMan;
    // Start is called before the first frame update
    void Start()
    {
        evMan.SpacebarPressed += MoveRight;
    }

    private void OnDestroy()
    {
        evMan.SpacebarPressed -= MoveRight;
    }

    void MoveRight(float receivedFloat)
    {
        transform.position += new Vector3(receivedFloat, 0, 0);
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
