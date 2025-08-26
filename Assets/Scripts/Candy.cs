using UnityEngine;
using UnityEngine.SceneManagement;

public class Candy : MonoBehaviour
{
    public int candiesToAdd;
    public string nextSceneName;  // Scene name set korben Inspector theke
    public int scoreToChangeScene;

    void OnMouseDown()
    {
        CandyManager.Instance.AddCandy(candiesToAdd);

    }

    private void Update()
    {
        if (CandyManager.Instance.candyCount >= scoreToChangeScene)
        {
            SceneManager.LoadScene(nextSceneName);
        }
    }
}
