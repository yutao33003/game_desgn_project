using UnityEngine;

public class SingletonExample : MonoBehaviour
{
    private static SingletonExample instance;

    void Awake()
    {
        // 如果已經存在實例，則銷毀當前物件
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }

        // 如果不存在實例，將當前物件設為實例並保留在場景中
        instance = this;
        DontDestroyOnLoad(this.gameObject);
    }
}

