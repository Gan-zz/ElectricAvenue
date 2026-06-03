using UnityEngine;
//Quits the game on trigger
public class Quit : MonoBehaviour
{
    public void OnApplicationQuit()
    {
        Application.Quit();
    }
}
