using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement; // 用於場景跳轉

public class checkAnswer3 : MonoBehaviour
{
    public TMP_InputField inputField; // TextMeshPro 的 InputField
    public string correctAnswer;      // 正確答案

    public void CheckInputAndChangeScene()
    {
        // 檢查輸入是否正確
        if (inputField.text == correctAnswer)
        {
            Debug.Log("正確答案！跳轉到15頁");
            SceneManager.LoadScene(15); // 跳轉到15頁
        }
        else
        {
            Debug.Log("錯誤答案！跳轉到16頁");
            SceneManager.LoadScene(16); // 跳轉到16頁
        }
    }
}
