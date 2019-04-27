using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class wood_stack : MonoBehaviour
{
    public int currentScore;
    public Text UIText;

    // Start is called before the first frame update
    void Start()
    {
        currentScore = score.currentScore;
        UIText.text = "Score: " + currentScore.ToString();
    }

    private void OnTriggerStay(Collider col)
    {
        currentScore += 1;
        UIText.text = "Score: " + currentScore.ToString();
    }
}
