using UnityEngine;

public class CubeDestroyer : MonoBehaviour
{
    public Money money;
    public int moneyPerCube = 1;

    void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Cube")) return;

        // 💰 give money ONCE
        if (money != null)
        {
            money.AddMoney(moneyPerCube);
        }

        // 💥 destroy the cube
        Destroy(other.gameObject);
    }
}
