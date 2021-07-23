using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCounter : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other != null)
        {
            if(other.tag == "Player")
            {
                GameManager.tilesCont++;
            }
        }
    }
}
