using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement; // �Ω��������

public class checkAnswer3 : MonoBehaviour
{
    public TMP_InputField inputField; // TextMeshPro �� InputField
    public string correctAnswer;      // ���T����

    public void CheckInputAndChangeScene()
    {
        // �ˬd��J�O�_���T
        if (inputField.text == correctAnswer)
        {
            Debug.Log("���T���סI�����15��");
            SceneManager.LoadScene(15); // �����15��
        }
        else
        {
            Debug.Log("���~���סI�����16��");
            SceneManager.LoadScene(16); // �����16��
        }
    }
}
