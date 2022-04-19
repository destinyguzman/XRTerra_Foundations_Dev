using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FiringPad : MonoBehaviour
{
    public GameObject projectilePreFab;
    public Transform spawnpoint;
    public float projectileForce;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player triggered this firing pad!");
            GameObject spawnedProjectile = Instantiate(projectilePreFab, spawnpoint.position, spawnpoint.rotation);
            spawnedProjectile.GetComponent<Rigidbody>().AddForce(spawnedProjectile.transform.forward * projectileForce, ForceMode.Force);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
