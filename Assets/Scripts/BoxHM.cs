using UnityEngine;

public class BoxHM : MonoBehaviour
{
    public static BoxHM Instance;
    public int minHits = 5;
    public int maxHits = 25;

    void Awake()
    {
        Instance = this;
    }

    public void BoxDestroyed()
    {
        maxHits++; 
    }

    public int GetBoxHealth()
    {
        return Random.Range(minHits, maxHits + 1); 
    }
}
