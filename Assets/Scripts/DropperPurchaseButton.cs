using UnityEngine;

public class DropperPurchaseButton : MonoBehaviour
{
    public GameObject dropperPrefabToPlace;
    public int dropperAnchorIndex = -1;

    public GameObject buttonPrefabToUnlock;
    public int buttonAnchorIndex = -1;

    private bool purchased;

    void OnTriggerEnter(Collider other)
    {
        if (purchased) return;
        if (!other.CompareTag("Player")) return;

        // Place dropper
        if (dropperPrefabToPlace != null && dropperAnchorIndex >= 0)
        {
            Transform anchor =
                PlacementManager.Instance.GetDropperAnchor(dropperAnchorIndex);

            Instantiate(
                dropperPrefabToPlace,
                anchor.position,
                anchor.rotation
            );
        }

        // Unlock next button
        if (buttonPrefabToUnlock != null && buttonAnchorIndex >= 0)
        {
            Transform anchor =
                PlacementManager.Instance.GetButtonAnchor(buttonAnchorIndex);

            Instantiate(
                buttonPrefabToUnlock,
                anchor.position,
                anchor.rotation
            );
        }

        purchased = true;
        gameObject.SetActive(false);
    }
}
