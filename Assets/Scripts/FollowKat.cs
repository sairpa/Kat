using UnityEngine;

public class FollowKat : MonoBehaviour
{

    public Transform kat;
    public Vector3 offset;
   

    void Start()
    {

        offset.Set(0f, 1.5f, -3f);

    }
    void Update()
    {

        transform.position = kat.position + offset;
        
    }
    

    void FixedUpdate()
    {
        
    }
}
