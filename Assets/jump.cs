using UnityEngine;
using UnityEngine.SceneManagement;

public class jump : MonoBehaviour
{
    // �������w�������q�Τ�k�]�ϥγ������ޡ^
    public void JumpToPage(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);  // �����[������
    }

    // �ϥγ����W�٨ӥ[������
    public void JumpToPage(string sceneName)
    {
        SceneManager.LoadScene(5);  // �����[������
    }
}
