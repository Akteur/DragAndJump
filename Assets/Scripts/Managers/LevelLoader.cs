using System.Collections;
using UnityEngine;

public class LevelLoader : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            StartCoroutine(ReusePlatform());
        }
    }

    IEnumerator ReusePlatform()
    {
        yield return new WaitForSeconds(1f);
        transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + 5 * 4);

    }
}
