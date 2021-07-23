using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreChanger : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI score;

    void Update()
    {
        score.text = GameManager.tilesCont.ToString();
    }
}
