using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WithdrawNum : MonoBehaviour
{
    public BalanceDisplay balanceDisplay;
    public CashDisplay cashDisplay;
    public int WithdrawAmount = 10000; // 인스펙터 창에서 조절할 입금 금액 변수

    private void Start()
    {
        
        GetComponent<Button>().onClick.AddListener(WithdrawInputN);
    }

    private void WithdrawInputN()
    {
        float currentCash = DataManager.Instance.LoadCash(); // PlayerCash를 가져옴
        float currentBalance = DataManager.Instance.LoadPlayerBalance();
        // 현재 Cash가 입금 금액보다 적으면 입금하지 않음
        if (currentBalance < WithdrawAmount)
        {
            Debug.LogWarning("Cash가 부족합니다.");
            UIManager.Instance.InsufficientWindow();
            return;
        }

        // 입금 금액을 PlayerBalance에 추가
        
        currentBalance -= WithdrawAmount;
        DataManager.Instance.SaveBalance(currentBalance);

        // Cash에서 입금 금액을 차감
        currentCash += WithdrawAmount;
        DataManager.Instance.SaveCash(currentCash);

        balanceDisplay.UpdateBalanceText(currentBalance);
        cashDisplay.UpdateCashText(currentCash);
        UIManager.Instance.ReturnIntro();
    }
}
