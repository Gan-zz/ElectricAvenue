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
        //if the Time is above or equal to 0
        if (elapsedTime >= 0)
        {
            elapsedTime += Time.deltaTime;
        }
        
        int minutes = Mathf.FloorToInt(elapsedTime / 60);
        int seconds = Mathf.FloorToInt(elapsedTime % 60);
        //Changes the text of the timerText to the Time
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
