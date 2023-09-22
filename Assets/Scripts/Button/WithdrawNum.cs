using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WithdrawNum : MonoBehaviour
{
    public BalanceDisplay balanceDisplay;
    public CashDisplay cashDisplay;
    public int WithdrawAmount = 10000; // �ν����� â���� ������ �Ա� �ݾ� ����

    private void Start()
    {
        
        GetComponent<Button>().onClick.AddListener(WithdrawInputN);
    }

    private void WithdrawInputN()
    {
        float currentCash = DataManager.Instance.LoadCash(); // PlayerCash�� ������
        float currentBalance = DataManager.Instance.LoadPlayerBalance();
        // ���� Cash�� �Ա� �ݾ׺��� ������ �Ա����� ����
        if (currentBalance < WithdrawAmount)
        {
            Debug.LogWarning("Cash�� �����մϴ�.");
            UIManager.Instance.InsufficientWindow();
            return;
        }

        // �Ա� �ݾ��� PlayerBalance�� �߰�
        
        currentBalance -= WithdrawAmount;
        DataManager.Instance.SaveBalance(currentBalance);

        // Cash���� �Ա� �ݾ��� ����
        currentCash += WithdrawAmount;
        DataManager.Instance.SaveCash(currentCash);

        balanceDisplay.UpdateBalanceText(currentBalance);
        cashDisplay.UpdateCashText(currentCash);
        UIManager.Instance.ReturnIntro();
    }
}
