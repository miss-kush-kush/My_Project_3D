using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class CollectStar : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        ScoringSystem.theScore += 10;

        Destroy(gameObject);
    }
}
