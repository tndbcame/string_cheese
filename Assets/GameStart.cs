using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStart : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int age;
        age = 30;
        Debug.Log(age);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SwitchScene()
    {
        SceneManager.LoadScene("GameScene", LoadSceneMode.Single);
    }
}
