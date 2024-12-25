using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Controler_DFS_QA : MonoBehaviour
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
        SceneManager.LoadScene(4);
    }
    public void SwitchScene_BFS_2(){
        SceneManager.LoadScene(2);
    }
}
