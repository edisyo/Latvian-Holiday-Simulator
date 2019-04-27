using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerScore : MonoBehaviour
{
    public int currentScore;
    public Text UIText;
    void Update()
    {
        UIText.text = "Score: " + currentScore.ToString();
    }
}
