using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreUp : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Score.score++; // Increase score by 1 on collision with balloon
    }
}
