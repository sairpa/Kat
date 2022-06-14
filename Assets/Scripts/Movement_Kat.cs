using UnityEngine;

using UnityEngine.UI;

public class Movement_Kat : MonoBehaviour
{

    public float front=600f;

    public Text score;

    public Rigidbody rb;
    public bool jump = false;
   
    private void Update()
    {
        jump = false;
        if (Input.GetKey("space"))
        {
            jump = true;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey("w") || Input.GetKey(KeyCode.UpArrow))
        {
            rb.AddForce(0, 0, 5 * front * Time.deltaTime);
        }

        if (Input.GetKey("s") || Input.GetKey(KeyCode.DownArrow))
        {
            rb.AddForce(0, 0, -5 * front * Time.deltaTime);
        }

        if (Input.GetKey("a") || Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(-0.05f * front * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }

        if (Input.GetKey("d") || Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(0.05f * front * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (jump == true)
        {
            rb.AddForce(0, 4*front * Time.deltaTime, 0);
        }

        if(rb.position.y < -1f)
        {
            string s = "Game Over";
            score.text = s;
            score.color = Color.red;
            FindObjectOfType<GameManager>().EndGame();
        }

    }
}
