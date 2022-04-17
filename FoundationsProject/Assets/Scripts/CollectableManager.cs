using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableManager : MonoBehaviour
{
    public static CollectableManager Instance;
    public int totalCubesToCollect;
    public int collectedCount;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(this);
        }
    }

    public void AddOneToCount()
    {
        collectedCount++;
        if (collectedCount != totalCubesToCollect)
        {
            Debug.Log("You have collected another one! You're now at " + collectedCount + "/" + totalCubesToCollect + " cubes!");
        }
            if(collectedCount == totalCubesToCollect)
        {
            Debug.Log("You win! You collected all of the cubes!");
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        collectedCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
