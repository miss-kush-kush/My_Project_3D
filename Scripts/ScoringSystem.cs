using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoringSystem : MonoBehaviour
{
    public GameObject scoreText;
    public static int theScore;

    void Update()
    {
        TextMeshProUGUI textComponent = scoreText.GetComponent<TextMeshProUGUI>();
    
        if (textComponent != null)
        {
            textComponent.text = "SCORE: " + theScore;
        }
        else
        {
            Debug.LogError("TextMeshProUGUI component not found on scoreText GameObject.");
        }
    
    }
}
