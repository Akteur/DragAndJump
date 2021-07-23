using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float sensetivity;
    [SerializeField] Vector2 pos;
    [SerializeField] Vector2 startPos;

    private Vector3 position;
    private float width;
    // Start is called before the first frame update
    void Start()
    {
        speed = speed / 100;
        sensetivity = sensetivity / 100;
        startPos = new Vector2(0, 0);
        width = Screen.width / 1.0f;
    }
    void FixedUpdate()
    {
        if (GameManager.instance.gameStarted)
        {
            MoveForward();
            MoveBySides();
        }
    }
    void MoveBySides()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);      
            if(touch.phase == TouchPhase.Began)
            {
                startPos = touch.position;
                startPos.x = (startPos.x - width) / width;
            }
            if (touch.phase == TouchPhase.Moved)
            {
                pos = touch.position;

                pos.x = (pos.x - width) / width;
                pos.x = (startPos.x - pos.x) * sensetivity;
                position = new Vector3(transform.position.x - pos.x, transform.position.y, transform.position.z);

                transform.position = position;
            }
        }
    }
    void MoveForward()
    {
        transform.position += transform.forward * speed;
    }
}
