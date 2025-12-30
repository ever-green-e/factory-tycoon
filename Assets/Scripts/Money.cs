using UnityEngine;

public class Money : MonoBehaviour
{
    public int money = 0;

    public void AddMoney(int amount)
    {
        money += amount;
    }
}
