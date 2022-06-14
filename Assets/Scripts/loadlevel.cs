using UnityEngine.SceneManagement;
using UnityEngine;

public class loadlevel : MonoBehaviour
{
    public void loadnextlevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
    }
}
