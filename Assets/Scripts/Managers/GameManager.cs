using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public static int tilesCont;
    public static bool MenuLoaded = true;
    public bool canMove;
    public bool gameStarted;
    public bool startTimer;

    private void Awake()
    {
        if(instance != null)
        {
            Destroy(instance);
        }
        else
        {
            instance = this;
        }
        DontDestroyOnLoad(instance);
    }
    private void Start()
    {
        if(SceneManager.GetActiveScene().name == "MainMenu")
        {
            MenuLoaded = true;
        }
        else
        {
            tilesCont = 0;
            MenuLoaded = false;
        }
    }
}
