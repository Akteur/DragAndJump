using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMenu : MonoBehaviour
{
    public void StartGame()
    {
        GameManager.instance.startTimer = true;
        this.gameObject.SetActive(false);
    }
}
