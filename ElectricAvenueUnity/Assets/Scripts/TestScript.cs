using UnityEngine;

public class TestScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Sends messages to the unity console, speciffically regular,error and warning
        Debug.Log("Hello");
        Debug.LogError("Hello");
        Debug.LogWarning("Hello");
        transform.Rotate(0, 0, 180);
    }

    // Update is called once per frame
    void Update()
    {
        // Every frame sends this message to the console, very spammy
        Debug.Log("Hello!");
    }

}
