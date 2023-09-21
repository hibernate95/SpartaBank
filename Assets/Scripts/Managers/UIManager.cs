using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject loginPanel;
    public GameObject SignUpPanel;
    public GameObject DepositPanel;
    public GameObject WithdrawPanel;
    public GameObject Button;
    // Start is called before the first frame update
    public void Init()
    {
        loginPanel.SetActive(false);

    }
    public void ShowLoginPanel()
    {
        loginPanel.SetActive(true);
        
    }

    // Update is called once per frame
    public void ShowSignUpPanel()
    {
        
        SignUpPanel.SetActive(true);
        
    }

    public void ShowDepositPanel()
    {
        DepositPanel.SetActive(true);
        Button.SetActive(false);

    }

    public void ShowWithdrawPanel()
    {
        WithdrawPanel.SetActive(true);
        Button.SetActive(false);
    }
}
