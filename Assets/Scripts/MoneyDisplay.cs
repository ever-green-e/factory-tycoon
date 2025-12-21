using UnityEngine;
using TMPro;

public class MoneyDisplay : MonoBehaviour
{
    public TextMeshProUGUI moneyText; // TMP text
    public Money money;

    void Update()
    {
        moneyText.text = money.money.ToString();
    }
}
