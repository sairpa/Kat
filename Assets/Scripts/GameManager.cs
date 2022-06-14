using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    
    bool ended = false;

    public void EndGame()
    {
        if (!ended)
        {
            ended = true;
            Invoke("Restart", 2f);
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Restar()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1); 
    }

    public GameObject go;

    public void finale()
    {
        go.SetActive(true);
    }


}
