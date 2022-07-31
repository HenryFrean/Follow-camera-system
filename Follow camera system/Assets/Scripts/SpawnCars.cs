using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCars : MonoBehaviour
{
    
    public GameObject car;
    public float delaySpawn = 2f;
    public float intervalSpawn = 1f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnCar", delaySpawn, intervalSpawn);
    }

    private void SpawnCar()
    {
        Instantiate(car, transform.position, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
