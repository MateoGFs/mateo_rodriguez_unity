using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        move player = other.GetComponent<move>();
        if (player != null)
        {
            player.AddCoin(1);
            Destroy(gameObject);
        }
    }
}
