using UnityEngine;
using System.Collections;

public class BasicOreSpawner : MonoBehaviour
{
    public GameObject cubePrefab;

    void Start()
    {
        StartCoroutine(SpawnCubes());
    }

    IEnumerator SpawnCubes()
    {
        while (true)
        {
            Instantiate(cubePrefab, transform.position, Quaternion.identity);
            yield return new WaitForSeconds(1f);
        }
    }
}
