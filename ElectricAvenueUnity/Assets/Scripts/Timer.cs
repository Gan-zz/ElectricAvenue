using TMPro; 
using Unity.VisualScripting;
using UnityEngine; 
using UnityEngine.SceneManagement; 

public class Timer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText;
    [SerializeField] float elapsedTime;

    void Update()
    {
        //if the elapsedTime is above or equal to 0

        if (elapsedTime >= 0)
        {
            //increases the elapsed time by the time passed since the last frame
            //Time.deltaTime makes sure the timer updates smoothly regardless of frame rate
            elapsedTime += Time.deltaTime;
        }

        //convert the elapsed time into minutes and seconds
        //Mathf.FloorToInt rounds down to the nearest integer
        int minutes = Mathf.FloorToInt(elapsedTime / 60); //total minutes passed
        int seconds = Mathf.FloorToInt(elapsedTime % 60); //remaining seconds after accounting for minutes
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
