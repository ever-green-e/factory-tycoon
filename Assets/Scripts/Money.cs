using UnityEngine;

public class Money : MonoBehaviour
{
    public static Money Instance;

    public int money = 0;

    void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
    }

    public bool CanAfford(int amount)
    {
        return money >= amount;
    }

    public void Spend(int amount)
    {
        money -= amount;
    }

    public void AddMoney(int amount)
    {
        money += amount;
    }
}
