using UnityEngine;

public class CubeDestroyer : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Ore ore = other.GetComponent<Ore>();
        if (ore == null || ore.data == null) return;

        Money.Instance.AddMoney(ore.data.moneyValue);

        Destroy(other.gameObject);
    }
}
