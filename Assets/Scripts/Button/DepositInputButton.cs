using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DepositInputButton : MonoBehaviour
{
    public InputField depositInputField; // �Ա� �ݾ��� �Է��ϴ� Input Field
    public BalanceDisplay balanceDisplay; // BalanceDisplay ��ũ��Ʈ ����
    public CashDisplay cashDisplay;

    private void Start()
    {
        // Deposit ��ư�� Ŭ�� �̺�Ʈ �����ʸ� �߰��մϴ�.
        Button inputButton = GetComponent<Button>();
        inputButton.onClick.AddListener(PerformDeposit);
    }

    private void PerformDeposit()
    {
        // �Էµ� �Ա� �ݾ��� �����ɴϴ�. �Է��� ������� ��� 0���� �����մϴ�.
        if (float.TryParse(depositInputField.text, out float depositAmount))
        {
            // ���� PlayerBalance�� �����ɴϴ�.
            float currentBalance = PlayerPrefs.GetFloat("PlayerBalance", 0f);

            float currentCash = PlayerPrefs.GetFloat("PlayerCash", 0f);

            // ���� Cash�� �Ա� �ݾ׺��� ������ �Ա����� ����
            if (currentCash < depositAmount)
            {
                Debug.LogWarning("Cash�� �����մϴ�.");
                UIManager.Instance.InsufficientWindow();
                return;
            }

            // �Ա� �ݾ��� PlayerBalance�� �߰��մϴ�.
            currentBalance += depositAmount;
            DataManager.Instance.SaveBalance(currentBalance);

            // Cash���� �Ա� �ݾ��� �����մϴ�.
            currentCash -= depositAmount;
            DataManager.Instance.SaveCash(currentCash);


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
