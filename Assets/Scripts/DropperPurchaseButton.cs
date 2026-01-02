using UnityEngine;
using System.Collections.Generic;

public class DropperPurchaseButton : MonoBehaviour
{
    [Header("Cost")]
    public int cost = 50;

    [Header("Droppers to Place")]
    public List<GameObject> dropperPrefabs;
    public List<int> dropperAnchorIndices;

    [Header("Buttons to Unlock")]
    public List<GameObject> buttonPrefabs;
    public List<int> buttonAnchorIndices;

    private bool purchased = false;

    void OnTriggerEnter(Collider other)
    {
        if (purchased) return;
        if (!other.CompareTag("Player")) return;

        // 💰 CHECK MONEY FIRST
        if (!Money.Instance.CanAfford(cost))
        {
            Debug.Log("Not enough money!");
            return;
        }

        // 💸 SPEND MONEY
        Money.Instance.Spend(cost);

        // 🏭 Place droppers
        for (int i = 0; i < Mathf.Min(dropperPrefabs.Count, dropperAnchorIndices.Count); i++)
        {
            Transform anchor =
                PlacementManager.Instance.GetDropperAnchor(dropperAnchorIndices[i]);

            Instantiate(
                dropperPrefabs[i],
                anchor.position,
                anchor.rotation
            );
        }

        // 🔓 Unlock new buttons
        for (int i = 0; i < Mathf.Min(buttonPrefabs.Count, buttonAnchorIndices.Count); i++)
        {
            Transform anchor =
                PlacementManager.Instance.GetButtonAnchor(buttonAnchorIndices[i]);

            Instantiate(
                buttonPrefabs[i],
                anchor.position,
                anchor.rotation
            );
        }

        purchased = true;
        gameObject.SetActive(false);
    }
}
