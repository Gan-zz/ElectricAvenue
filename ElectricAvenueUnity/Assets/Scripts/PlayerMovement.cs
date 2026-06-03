using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    public float speed = 1f; //horizontal movement
    public float verticalSpeed = 1f; //vertical movement
    private Rigidbody2D physicsBody = null;

    public void Update()
    {
        // Get our rigidbody that we'll need to find the physics information
        Rigidbody2D ourRigidbody = GetComponent<Rigidbody2D>();
        
        // Find out from the rigidbody what our current horizontal and vertical speeds
        float currentSpeedH = ourRigidbody.linearVelocity.x;
        float currentSpeedV = ourRigidbody.linearVelocity.y;
        
        // Get the animator component that we will be using for setting our animation
        Animator ourAnimator = GetComponent<Animator>();
        
        // Tell our animator what the speeds are
        ourAnimator.SetFloat("SpeedH", currentSpeedH); 
        ourAnimator.SetFloat("SpeedV", currentSpeedV);
    }

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
