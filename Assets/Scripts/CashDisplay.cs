using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CashDisplay : MonoBehaviour
{
    public Text cashDisplay;
    // Start is called before the first frame update
    private void Start()
    {
        float playerCash = DataManager.Instance.LoadCash();
        UpdateCashText(playerCash);
    }

    public void UpdateCashText(float newCash)
    {
        if (cashDisplay != null)
        {
            cashDisplay.text = "Çö±Ý:    " + newCash.ToString("F0");
        }
    }
}
