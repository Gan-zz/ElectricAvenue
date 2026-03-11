using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeToScene : MonoBehaviour
{
    public void SceneChange(string targetSceneName)
    {
        SceneManager.LoadScene(targetSceneName);
    }

}
