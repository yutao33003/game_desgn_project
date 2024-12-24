using UnityEngine;
using UnityEngine.SceneManagement;

public class jump : MonoBehaviour
{
    // 跳轉到指定場景的通用方法（使用場景索引）
    public void JumpToPage(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);  // 直接加載場景
    }

    // 使用場景名稱來加載場景
    public void JumpToPage(string sceneName)
    {
        SceneManager.LoadScene(5);  // 直接加載場景
    }
}
