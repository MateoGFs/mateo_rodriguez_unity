using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class move : MonoBehaviour
{
    [SerializeField]
    private float speed = 1f;
    public float horizontalInput;
    public float verticalInput;
    public GameObject miObjeto;
    public GameObject miOtroObjeto;
    public bool cambiaObjeto = false;



    public int coins = 0;
    public TextMeshProUGUI coinText;
    

    public void AddCoin(int amount)
    {
        coins += amount;
        UpdateCoinUI();
    }

    void UpdateCoinUI()
    {
        if (coinText != null)
            coinText.text = "Coins: " + coins;
    }
    void Start()
    {
        UpdateCoinUI();
    }
    
    void Update()
    {

        if(Input.GetKeyDown(KeyCode.Space))
        {
            //Instantiate(miObjeto, transform.position, Quaternion.identity);
            cambiaMiObjeto();
        }

        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);

        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);

        if(transform.position.z > 7f)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 7f);

        }
        else if(transform.position.z < -7.1f)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -7.1f);
        }


        if (transform.position.x > 4.8f)
        {
            transform.position = new Vector3(4.8f, transform.position.y, transform.position.z);
        }
        else if (transform.position.x < -4.7f)
        {
            transform.position = new Vector3(-4.7f, transform.position.y, transform.position.z);
        }

    }

    private void cambiaMiObjeto()
    {
        if(cambiaObjeto == true)
        {
            Instantiate(miOtroObjeto, transform.position, Quaternion.identity);
        }
        else
        {
            Instantiate(miObjeto, transform.position, Quaternion.identity);
        }
    }
}
