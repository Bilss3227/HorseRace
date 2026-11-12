using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
   
    
    
    [SerializeField] private float speed = 10.2f;
    [SerializeField] private Rigidbody rbPlayer;
    

    
    void FixedUpdate()
    {
        rbPlayer.AddForce(0.0f, 0.0f, speed);
    }
}
