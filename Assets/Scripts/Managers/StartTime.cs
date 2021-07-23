using System.Collections;
using TMPro;
using UnityEngine;

public class StartTime : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI textMesh;
    [SerializeField] GameObject start;
    bool coroutineStarted;
    void Start()
    {
        textMesh.text = "";
    }

    void Update()
    {
        if (GameManager.instance.startTimer && !coroutineStarted)
        {
            StartCoroutine(startTime());
        }
    }

    IEnumerator startTime()
    {
        coroutineStarted = true;
        for(int i = 4; i > 0; i--)
        {
            yield return new WaitForSeconds(0.9f);
            int time = i - 1;
            textMesh.text = time.ToString();
        }
        textMesh.text = "";
        GameManager.instance.gameStarted = true;
        Destroy(start);
        StopAllCoroutines();
    }
}
