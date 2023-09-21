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

    // Update is called once per frame
    public void ShowSignUpPanel()
    {
        
        SignUpPanel.SetActive(true);
    }

    public void ShowDpositPanel()
    {
        DepositPanel.SetActive(true);
    }

    public void ShowWithdrawPanel()
    {
        WithdrawPanel.SetActive(true);
    }
}
