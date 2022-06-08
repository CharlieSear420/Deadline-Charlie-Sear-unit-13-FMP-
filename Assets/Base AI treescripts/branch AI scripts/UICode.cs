using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UICode : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void Awake()
    {
        Time.timeScale = 1f;

    }


    public void LoadScene(string SampleScene)
    {
        
        SceneManager.LoadScene(SampleScene);
        Time.timeScale = 1f;
    }

    public void Quit()
    {
        Application.Quit();
        //UnityEditor.EditorApplication.isPlaying = false;
        //edit the above line out when building the game

    }

}
