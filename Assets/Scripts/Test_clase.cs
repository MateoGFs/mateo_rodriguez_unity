using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_clase : MonoBehaviour
{
    public float posX = -0.23f;
    public float posY = 7.99f;
    public float posZ = 9.63f;
    void Start()
    {
        transform.position = new Vector3(posX, posY, posZ);
        //Debug.Log("Hello World Unity");
    }

    
    void Update()
    {
        Debug.Log("Hello World Unity");
    }
}
