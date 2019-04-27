using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class score2pot : MonoBehaviour
{
    public Text UIText;
    public int currentScore = score.currentScore;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "BadPotato") {
            currentScore += 1;
            UIText.text = "Score: " + currentScore.ToString();
            Debug.Log("Meme");
        }
        else if(other.gameObject.tag == "GoodPotato")
        {
            currentScore -= 1;
            UIText.text = "Score: " + currentScore.ToString();
        }
    }

}
