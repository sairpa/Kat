using UnityEngine;
using UnityEngine.UI;

public class KatCollision : MonoBehaviour
{
        public Movement_Kat movement;
        public Text score;
    
    public Score sc;

    private void OnCollisionEnter(Collision collision)
    {
       if(collision.collider.tag == "Obstacle")
        {
            string s = "Game Over";
            score.text = s;
            score.color = Color.red;
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
            sc.enabled = false;
            
        }
    }
}
