using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TestButton2 : MonoBehaviour
{

    CountButton button;

    private int count = 0;
    [SerializeField] private TextMeshProUGUI text;
    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<CountButton>();
        button.onClickCallback = () =>
        {
            count = count + 1;
            text.text = count.ToString();
        };
    }
}
