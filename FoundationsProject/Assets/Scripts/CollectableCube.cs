using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableCube : MonoBehaviour
{
    MeshRenderer rend;
    BoxCollider collider;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<MeshRenderer>();
        collider = GetComponent<BoxCollider>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Collided with Player!");
            rend.enabled = false;
            collider.enabled = false;
            CollectableManager.Instance.AddOneToCount();
        }
        
    }
    // Update is called once per frame
    void Update()
    {
         
    }
}
