using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Controler_Main_BFS : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SwitchScene(){
        SceneManager.LoadScene(2);
    }
    public void SwitchScene_BFS_1(){
        SceneManager.LoadScene(2);
    }
    public void SwitchScene_DFS_1(){
        SceneManager.LoadScene(3);
    }
}
