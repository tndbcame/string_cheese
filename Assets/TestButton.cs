using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TestButton : MonoBehaviour
{

    StartButton button;
    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<StartButton>();

        button.onClickCallback = () =>
        {
            SceneManager.LoadScene("GameScene", LoadSceneMode.Single);
        };
    }
}
