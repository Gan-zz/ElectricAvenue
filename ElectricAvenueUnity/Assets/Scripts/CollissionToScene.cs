using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Collision : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //code to handle collision
        //Get the collider of the object we collided with
        Collider2D collider = collision.collider;
        SceneManager.LoadScene("EndScene");
    }
}

