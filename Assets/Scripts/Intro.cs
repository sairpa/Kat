using UnityEngine;
using UnityEngine.SceneManagement;

public class Intro : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
