using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject loginPanel;
    public GameObject SignUpPanel;
    public GameObject DepositPanel;
    public GameObject WithdrawPanel;

    // Start is called before the first frame update
    public void ShowLoginPanel()
    {
        loginPanel.SetActive(true);
        
    }

    private static UIManager instance;

    // UIManager의 인스턴스를 반환하는 프로퍼티
    public static UIManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<UIManager>();

                if (instance == null)
                {
                    GameObject go = new GameObject("UIManager");
                    instance = go.AddComponent<UIManager>();
                }
            }
            return instance;
        }
    }

    // Update is called once per frame
    public void ShowSignUpPanel()
    {
        
        SignUpPanel.SetActive(true);
    }

    public void ShowDepositPanel()
    {
        DepositPanel.SetActive(true);
    }

    public void ShowWithdrawPanel()
    {
        WithdrawPanel.SetActive(true);
    }
}
