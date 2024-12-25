using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class BFS : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SwitchScene_BFS(){
        SceneManager.LoadScene(6);
    }
    public void SwitchScene_DFS(){
        SceneManager.LoadScene(7);
    }
}
