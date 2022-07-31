using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public GameObject[] cameras;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F1))
        {
            cameras[1].SetActive(true);
            cameras[0].SetActive(false);
        }
        if (Input.GetKeyUp(KeyCode.F1))
        {
            cameras[1].SetActive(false);
            cameras[0].SetActive(true);
        }


    }
}
