using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class score : MonoBehaviour
{
    public Text UIText;
    public int currentScore = 0;
    public GameObject pot;
    private void OnTriggerEnter(Collider other)
    {
        if (pot.name == "Pot_good")
        {
            if (other.gameObject.tag == "GoodPotato") {
                currentScore += 1;
            }
            else if (other.gameObject.tag == "BadPotato")
            {
                currentScore -= 1;
            }
        }
        else if (pot.name == "Pot_bad") {
            if (other.gameObject.tag == "BadPotato")
            {
                currentScore += 1;
            }
            else if (other.gameObject.tag == "GoodPotato")
            {
                currentScore -= 1;
            }
        }
        UIText.text = "Score: " + currentScore.ToString();
    }

}
