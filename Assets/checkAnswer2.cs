using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement; // �Ω��������

public class checkAnswer2 : MonoBehaviour
{
    public TMP_InputField inputField; // TextMeshPro �� InputField
    public string correctAnswer;      // ���T����

    public void CheckInputAndChangeScene()
    {
        // �ˬd��J�O�_���T
        if (inputField.text == correctAnswer)
        {
            Debug.Log("���T���סI�����14��");
            SceneManager.LoadScene(14); // �����14��
        }
        else
        {
            Debug.Log("���~���סI�����13��");
            SceneManager.LoadScene(13); // �����13��
        }
    }
}
