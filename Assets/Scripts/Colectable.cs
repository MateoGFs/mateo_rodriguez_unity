using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colectable : MonoBehaviour
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
        //Debug.Log("Colisione con: " + other.name);
        //Accediendo a las variables y metodos de la clase player 
        move myobject = other.GetComponent<move>();
        myobject.cambiaObjeto = true;
        Destroy(this.gameObject);
    }
}
