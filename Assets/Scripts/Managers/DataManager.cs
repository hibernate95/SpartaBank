using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    public static DataManager Instance;
    // Start is called before the first frame update

    public void Init()
    {
         
    }


    private void Awake()
    {
        if (Instance == null)
        {
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void SaveBalance(float balance)
    {
        PlayerPrefs.SetFloat("PlayerBalance", balance);
    }

    public float LoadPlayerBalance()
    {
        return PlayerPrefs.GetFloat("PlayerBalance", 50000f);
    }

    public void SaveCash(float  cash)
    {
        PlayerPrefs.SetFloat("PlayerCash", cash);
    }

    public float LoadCash() 
    {
        return PlayerPrefs.GetFloat("PlayerCash", 100000f);
    }

    
}
