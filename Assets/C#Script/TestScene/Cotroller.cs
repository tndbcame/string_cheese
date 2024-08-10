using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cotroller : MonoBehaviour
{

    public Text aa;
    private int point = 0;
    public static bool isGetPoint = false;
    private void Update()
    {
        if (!Cube.isGameOver && isGetPoint)
        {
            Debug.Log("a");
            aa.text = $"ポイント:{point++}";
            isGetPoint = false;
        }else if (Cube.isGameOver)
        {
            aa.text = "ゲームオーバー";
        }
    }
}
