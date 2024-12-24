using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement; // 用於場景跳轉

public class checkAnswer2 : MonoBehaviour
{
    public TMP_InputField inputField; // TextMeshPro 的 InputField
    public string correctAnswer;      // 正確答案

    public void CheckInputAndChangeScene()
    {
        // 檢查輸入是否正確
        if (inputField.text == correctAnswer)
        {
            Debug.Log("正確答案！跳轉到14頁");
            SceneManager.LoadScene(14); // 跳轉到14頁
        }
        else
        {
            Debug.Log("錯誤答案！跳轉到13頁");
            SceneManager.LoadScene(13); // 跳轉到13頁
        }
    }
}
