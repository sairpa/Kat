using UnityEngine;

public class finale : MonoBehaviour
{

    public GameManager gm;

    private void OnTriggerEnter(Collider other)
    {

        gm.finale();

    }
}
