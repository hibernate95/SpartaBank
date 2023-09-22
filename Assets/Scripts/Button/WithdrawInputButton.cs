using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class WithdrawInputButton : MonoBehaviour
{
    public InputField WithdrawInputField; // �Ա� �ݾ��� �Է��ϴ� Input Field
    public BalanceDisplay balanceDisplay; // BalanceDisplay ��ũ��Ʈ ����
    public CashDisplay cashDisplay;

    private void Start()
    {
        // Deposit ��ư�� Ŭ�� �̺�Ʈ �����ʸ� �߰��մϴ�.
        Button inputButton = GetComponent<Button>();
        inputButton.onClick.AddListener(PerformWithdraw);
    }

    private void PerformWithdraw()
    {
        // �Էµ� �Ա� �ݾ��� �����ɴϴ�. �Է��� ������� ��� 0���� �����մϴ�.
        if (float.TryParse(WithdrawInputField.text, out float WithdrawAmount))
        {
            // ���� PlayerBalance�� �����ɴϴ�.
            float currentBalance = PlayerPrefs.GetFloat("PlayerBalance", 0f);

            float currentCash = PlayerPrefs.GetFloat("PlayerCash", 0f);

            // ���� Balance�� �Ա� �ݾ׺��� ������ �Ա����� ����
            if (WithdrawAmount > currentBalance)
            {
                Debug.LogWarning("Balance�� �����մϴ�.");
                UIManager.Instance.InsufficientWindow();
                return;
            }

            // �Ա� �ݾ��� PlayerBalance�� �߰��մϴ�.
            currentCash += WithdrawAmount;
            DataManager.Instance.SaveCash(currentCash);

            // Cash���� �Ա� �ݾ��� �����մϴ�.
            currentBalance -= WithdrawAmount;
            DataManager.Instance.SaveBalance(currentBalance);


            // BalanceDisplay ��ũ��Ʈ�� ������Ʈ �޼��带 ȣ���Ͽ� �ܰ� �ؽ�Ʈ�� �����մϴ�.
            balanceDisplay.UpdateBalanceText(currentBalance);
            cashDisplay.UpdateCashText(currentCash);
            UIManager.Instance.ReturnIntro();
        }
        else
        {
            Debug.LogWarning("�Էµ� �ݾ��� �ùٸ��� ��ȯ�� �� �����ϴ�.");
        }
    }
}
