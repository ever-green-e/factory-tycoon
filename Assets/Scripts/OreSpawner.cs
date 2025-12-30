using UnityEngine;
using System.Collections;

public class OreSpawner : MonoBehaviour
{
    public OreData oreData;      // 👈 THIS fixes the error
    public Transform spawnPoint;

    void Start()
    {
        StartCoroutine(SpawnOre());
    }

    IEnumerator SpawnOre()
    {
        while (true)
        {
            GameObject ore = Instantiate(
                oreData.orePrefab,
                spawnPoint.position,
                spawnPoint.rotation
            );

            // assign ore data
            Ore oreComponent = ore.GetComponent<Ore>();
            if (oreComponent != null)
            {
                oreComponent.data = oreData;
            }

            // apply color
            Renderer r = ore.GetComponent<Renderer>();
            if (r != null)
            {
                r.material.color = oreData.oreColor;
            }

            yield return new WaitForSeconds(oreData.spawnInterval);
        }
    }
}
