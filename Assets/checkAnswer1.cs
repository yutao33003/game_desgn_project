using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement; // �Ω��������

public class checkAnswer1 : MonoBehaviour
{
    public TMP_InputField inputField; // TextMeshPro �� InputField
    public string correctAnswer;      // ���T����

    public void CheckInputAndChangeScene()
    {
        // �ˬd��J�O�_���T
        if (inputField.text == correctAnswer)
        {
            Debug.Log("���T���סI�����12��");
            SceneManager.LoadScene(12); // �����12��
        }
        else
        {
            Debug.Log("���~���סI�����11��");
            SceneManager.LoadScene(11); // �����11��
        }
    }
}