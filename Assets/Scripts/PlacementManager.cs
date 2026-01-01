using UnityEngine;
using System.Collections.Generic;

public class PlacementManager : MonoBehaviour
{
    public static PlacementManager Instance;

    [Header("Button Anchors")]
    public List<Transform> buttonAnchors;

    [Header("Dropper Anchors")]
    public List<Transform> dropperAnchors;



    void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
    }

    public Transform GetButtonAnchor(int index)
    {
        return buttonAnchors[index];
    }

    public Transform GetDropperAnchor(int index)
    {
        return dropperAnchors[index];
    }
}
