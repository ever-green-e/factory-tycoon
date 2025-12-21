using UnityEngine;

public class CubeDestroyer : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Cube")) return;

        Destroy(other.gameObject);
    }
}
