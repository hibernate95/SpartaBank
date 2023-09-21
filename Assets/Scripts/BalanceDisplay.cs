using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;
using UnityEngine.UI;

public class BalanceDisplay : MonoBehaviour
{


    public Text balanceDisplay;

    // Start is called before the first frame update

    private void Start()
    {
        float playerBalance = DataManager.Instance.LoadPlayerBalance();
        UpdateBalanceText(playerBalance);
    }

    public void UpdateBalanceText(float newBalance)
    {
        if (balanceDisplay != null) 
        {
            balanceDisplay.text = "¿‹±›:     " + newBalance.ToString("F0");
        }
    }
}
