using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoringSystem : MonoBehaviour
{
    public GameObject scoreText;
    public int theScore;

    void OnTriggerEnter(Collider other)
    {
        theScore += 10;

        if (scoreText != null)
        {
            Text textComponent = scoreText.GetComponent<Text>();

            if (textComponent != null)
            {
                textComponent.text = "SCORE: " + theScore;
            }
            else
            {
                Debug.LogError("Text component not found on scoreText GameObject.");
            }
        }
        else
        {
            Debug.LogError("scoreText GameObject not assigned.");
        }

        Destroy(gameObject);
    }

}
