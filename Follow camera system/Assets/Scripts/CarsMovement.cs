using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarsMovement : MonoBehaviour
{
    private Vector3 direction = new Vector3(3f, 0f, 0f);
    public float liveTime = 4f;
    public float speed = 2f;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("DestroyDelay", liveTime);
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
    private void Move()
    {
        transform.position += direction * speed * Time.deltaTime;
    }
    private void DestroyDelay()
    {
        Destroy(gameObject);
    }
}