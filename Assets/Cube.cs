using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public static bool isGameOver = false;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        isGameOver = true;
    }
}
