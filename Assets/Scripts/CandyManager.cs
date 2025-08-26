using UnityEngine;

public class CandyManager : MonoBehaviour
{
    public static CandyManager Instance;

    public int candyCount = 0;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // Persist across scenes
        }
        else
        {
            Destroy(gameObject); // Only allow one instance
        }
    }

    public void AddCandy( int candiesToAdd)
    {
        candyCount += candiesToAdd;
        Debug.Log("Candy Count: " + candyCount);
    }
}
