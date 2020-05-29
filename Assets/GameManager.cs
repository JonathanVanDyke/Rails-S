using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }


    void Start()
    {
        Invoke("LoadFirstScene", 5f);
    }


    void Update()
    {
        
    }

    private void LoadFirstScene()
    {
        SceneManager.LoadScene(1);
    }
}
