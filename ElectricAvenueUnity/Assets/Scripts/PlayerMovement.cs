using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    public float speed = 1f;
    private Rigidbody2D physicsBody = null;

    private void Awake()
    {
        physicsBody = GetComponent<Rigidbody2D>();
    }
    
    public void MoveLeft()
    {
        physicsBody.linearVelocityX = -speed;
    }

    public void MoveRight()
    {
        physicsBody.linearVelocityX = speed;
    }
}
