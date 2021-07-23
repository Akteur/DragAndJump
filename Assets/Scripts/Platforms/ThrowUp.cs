using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowUp : MonoBehaviour
{
    [SerializeField] Animation anim;
    [SerializeField] string animName;
    private void OnTriggerEnter(Collider other)
    {
        if (other != null)
        {
            if (other.gameObject.tag == "Player")
            {                
                ThrowPlayer(other.gameObject);
            }
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other != null)
        {
            if (other.gameObject.tag == "Player")
            {
                ThrowPlayer(other.gameObject);
            }
        }
    }
    void ThrowPlayer(GameObject player)
    {
        if (GameManager.instance.gameStarted)
        {
            anim = player.GetComponent<Animation>();
            anim.Play(animName);
            
        }
    }
}
