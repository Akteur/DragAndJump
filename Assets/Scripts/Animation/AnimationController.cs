using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    private void Start()
    {
        if (GameManager.instance.gameStarted)
        {
            GetComponent<Animation>().clip.legacy = true;
            GetComponent<Animation>().Play("JumpAnimation");
            GetComponent<Animator>().Play("JumpAnimation");
        }
    }
}
