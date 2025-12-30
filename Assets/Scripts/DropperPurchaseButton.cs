using UnityEngine;

public class DropperPurchaseButton : MonoBehaviour
{
    public GameObject dropperPrefab;
    public Transform spawnPoint;

    private bool purchased = false;

    void OnTriggerEnter(Collider other)
    {
        if (purchased) return;
        if (!other.CompareTag("Player")) return;

        Instantiate(dropperPrefab, spawnPoint.position, spawnPoint.rotation);
        purchased = true;

        // Optional: disable button visuals/collider
        gameObject.SetActive(false);
    }
}
