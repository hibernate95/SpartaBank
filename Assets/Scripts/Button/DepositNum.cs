using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DepositNum : MonoBehaviour
{
    public BalanceDisplay balanceDisplay;
    public CashDisplay cashDisplay;
    public int depositAmount = 10000; // �ν����� â���� ������ �Ա� �ݾ� ����

    private void Start()
    {
        // ��ư�� Ŭ���� �� "DepositInputN" �޼��带 ȣ���ϴ� �̺�Ʈ ������ �߰�
        GetComponent<Button>().onClick.AddListener(DepositInputN);
    }

    private void DepositInputN()
    {
        float currentCash = DataManager.Instance.LoadCash(); // PlayerCash�� ������

        // ���� Cash�� �Ա� �ݾ׺��� ������ �Ա����� ����
        if (currentCash < depositAmount)
        {
            Debug.LogWarning("Cash�� �����մϴ�.");
            UIManager.Instance.InsufficientWindow();
            return;
        }

        // �Ա� �ݾ��� PlayerBalance�� �߰�
        float currentBalance = DataManager.Instance.LoadPlayerBalance();
        currentBalance += depositAmount;
        DataManager.Instance.SaveBalance(currentBalance);

        // Cash���� �Ա� �ݾ��� ����
        currentCash -= depositAmount;
        DataManager.Instance.SaveCash(currentCash);

        balanceDisplay.UpdateBalanceText(currentBalance);
        cashDisplay.UpdateCashText(currentCash);
        UIManager.Instance.ReturnIntro();
    }
}
