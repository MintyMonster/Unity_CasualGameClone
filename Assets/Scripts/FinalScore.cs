using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalScore : MonoBehaviour
{
    private void Update()
    {
        GetComponent<UnityEngine.UI.Text>().text = Score.score.ToString(); // Game over screen score card
    }
}
