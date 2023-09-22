using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject loginPanel;
    public GameObject SignUpPanel;
    public GameObject DepositPanel;
    public GameObject WithdrawPanel;
    public GameObject ButtonBind;
    public GameObject Insufficient;
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
        ButtonBind.SetActive(false);
    }

    public void ShowWithdrawPanel()
    {
        WithdrawPanel.SetActive(true);
        ButtonBind.SetActive(false);
    }

    public void ReturnIntro()
    {
        ButtonBind.SetActive(true);
        WithdrawPanel.SetActive(false);
        DepositPanel.SetActive(false);
    }

    public void InsufficientWindow()
    {
        Insufficient.SetActive(true);
    }

    public void ReturnInsufficient()
    {
        Insufficient.SetActive(false);
    }
}
