using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NameCheck : MonoBehaviour
{
    [SerializeField] private TMP_InputField nameInput; // 使用 TextMeshPro 的 InputField
    [SerializeField] private string correctName = "正確的名字"; // 設定正確的名字
    
    public void CheckName()
    {
        // 取得輸入的文字並移除空白
        string inputName = nameInput.text.Trim();
        
        // 判斷名字是否正確
        if (inputName == correctName)
        {
            // 正確則跳轉到第三頁
            GameManager.Instance.LoadPage(3);
            // 或者使用: SceneManager.LoadScene("Page3");
        }
        else
        {
            // 錯誤則跳轉到第四頁
            GameManager.Instance.LoadPage(4);
            // 或者使用: SceneManager.LoadScene("Page4");
        }
    }
}
