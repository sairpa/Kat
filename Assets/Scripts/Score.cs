using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text score;

    public Transform kat;
   
    void Update()
    {
        score.text = kat.position.z.ToString("0");

    }
}
