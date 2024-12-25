using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text instructionText; // 指引文字
    public Text resultText;      // 結果文字
    public Button bfsButton;     // BFS 按鈕
    public Button dfsButton;     // DFS 按鈕

    void Start()
    {
        // 初始化指引文字
        instructionText.text = "BFS 是廣度優先搜尋，適合快速找到最近的路徑。\n" +
                               "DFS 是深度優先搜尋，會嘗試走到底，可能會繞遠路。\n" +
                               "選擇你認為合適的搜尋方式：";
        resultText.text = ""; // 清空結果文字

        // 為按鈕綁定事件
        bfsButton.onClick.AddListener(ChooseBFS);
        dfsButton.onClick.AddListener(ChooseDFS);
    }

    void ChooseBFS()
    {
        // 玩家選擇 BFS
        resultText.text = "你選擇了 BFS，成功找到最近的路徑！進入下一關！";
    }

    void ChooseDFS()
    {
        // 玩家選擇 DFS
        resultText.text = "你選擇了 DFS，路徑太複雜，你來不及到考場，遊戲結束！";
    }
}

