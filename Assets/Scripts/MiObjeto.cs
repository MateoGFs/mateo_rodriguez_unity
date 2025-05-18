using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiObjeto : MonoBehaviour
{
    public float speed = 5.0f;
    public float posZ = 7f;
    void Start()
    {
        
    }

    
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        if(transform.position.z > 7.6f)
        {
            Destroy(this.gameObject);
        }
        
    }

    void OnTriggerEnter(Collider other)
    {
        BoxH box = other.GetComponent<BoxH>();
        if (box != null)
        {
            box.TakeHit();
            Destroy(gameObject); 
        }
    }
}
