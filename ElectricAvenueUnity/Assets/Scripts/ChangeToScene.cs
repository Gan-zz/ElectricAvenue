using UnityEngine;
using UnityEngine.SceneManagement;


//changes the scene on trigger
public class ChangeToScene : MonoBehaviour
{
    public void SceneChange(string targetSceneName)
    {
        SceneManager.LoadScene(targetSceneName);
    }

}
