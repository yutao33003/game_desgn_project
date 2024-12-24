using UnityEngine;

public class SingletonExample : MonoBehaviour
{
    private static SingletonExample instance;

    void Awake()
    {
        // �p�G�w�g�s�b��ҡA�h�P����e����
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }

        // �p�G���s�b��ҡA�N��e����]����ҨëO�d�b������
        instance = this;
        DontDestroyOnLoad(this.gameObject);
    }
}

