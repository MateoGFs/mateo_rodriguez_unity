using UnityEngine;

public class BoxH : MonoBehaviour
{
    public int hitsToDestroy = 2; 
    private int currentHits = 0;


    void Start()
    {
        hitsToDestroy = BoxHM.Instance != null ? BoxHM.Instance.GetBoxHealth() : hitsToDestroy;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void TakeHit()
    {
        currentHits++;
        if (currentHits >= hitsToDestroy)
        {
            Destroy(gameObject);
            if (BoxHM.Instance != null)
                BoxHM.Instance.BoxDestroyed();
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            if (GameM.Instance != null)
                GameM.Instance.GameOver();
        }
    }


}