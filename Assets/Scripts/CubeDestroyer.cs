using UnityEngine;

public class CubeDestroyer : MonoBehaviour
{
    public Money money;

    void OnTriggerEnter(Collider other)
    {
        Ore ore = other.GetComponent<Ore>();
        if (ore == null || ore.data == null) return;

        // 💰 give money based on ore type
        money.AddMoney(ore.data.moneyValue);

        Destroy(other.gameObject);
    }
}
