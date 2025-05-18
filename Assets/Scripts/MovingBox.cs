using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingBox : MonoBehaviour
{
    public float speed = 2f;
    public float distance = 2f;
    private float offset;

    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
        offset = Random.Range(0f, 100f); 
        speed = Random.Range(1.5f, 3.5f); 
        distance = Random.Range(1.5f, 2.5f); 
    }

    void Update()
    {
        float move = Mathf.PingPong(Time.time * speed + offset, distance) - distance / 2f;
        transform.position = new Vector3(startPosition.x + move, startPosition.y, startPosition.z);
    }
}