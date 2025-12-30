using UnityEngine;

[CreateAssetMenu(menuName = "Tycoon/Ore Data")]
public class OreData : ScriptableObject
{
    public GameObject orePrefab;
    public float spawnInterval = 1f;
    public Color oreColor = Color.white;

    public int moneyValue = 1; // 💰 NEW
}
