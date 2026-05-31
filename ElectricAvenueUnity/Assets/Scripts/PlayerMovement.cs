using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    public float speed = 1f; //horizontal movement
    public float verticalSpeed = 1f; //vertical movement
    private Rigidbody2D physicsBody = null;

    private void Awake()
    {
        physicsBody = GetComponent<Rigidbody2D>();
    }
    //moves left
    public void MoveLeft()
    {
        physicsBody.linearVelocityX = -speed;
    }
    //moves right
    public void MoveRight()
    {
        physicsBody.linearVelocityX = speed;
    }
    //moves upward
    public void MoveUp()
    {
        physicsBody.linearVelocityY = verticalSpeed;
    }

    //moves downward
    public void MoveDown()
    {
        physicsBody.linearVelocityY = -verticalSpeed;
    }

    //stops horizontal movement
    public void StopHorizontalMovement()
    {
        physicsBody.linearVelocityX = 0f;
    }

    //stops vertical movement
    public void StopVerticalMovement()
    {
        physicsBody.linearVelocityY = 0f;
    }

}
