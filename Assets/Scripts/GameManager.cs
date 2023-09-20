using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class GameManager : MonoBehaviour
{
    private DataManager dataManager;

    private void Awake()
    {
        dataManager = FindObjectOfType<DataManager>();
    }

    public void SavePlayerBalance(float balance)
    {
        dataManager.SaveBalance(balance);
    }

    public float LoadPlayerBalance()
    {
        return dataManager.LoadPlayerBalance();
    }
}
