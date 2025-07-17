using UnityEngine;
using UnityEngine.SceneManagement;

public class Candy1 : MonoBehaviour
{
    public int candiesToAdd;

    void OnMouseDown()
    {
        CandyManager.Instance.AddCandy(candiesToAdd);

    }
}
