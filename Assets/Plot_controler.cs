using UnityEngine;
using UnityEngine.SceneManagement;

public class Plot_controler : MonoBehaviour
{
    public void LoadSceneByName(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
