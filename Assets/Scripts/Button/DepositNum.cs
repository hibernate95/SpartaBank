using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DepositNum : MonoBehaviour
{
    public BalanceDisplay balanceDisplay;
    public CashDisplay cashDisplay;
    public int depositAmount = 10000; // 인스펙터 창에서 조절할 입금 금액 변수

    private void Start()
    {
        // 버튼을 클릭할 때 "DepositInputN" 메서드를 호출하는 이벤트 리스너 추가
        GetComponent<Button>().onClick.AddListener(DepositInputN);
    }

    private void DepositInputN()
    {
        float currentCash = DataManager.Instance.LoadCash(); // PlayerCash를 가져옴

        // 현재 Cash가 입금 금액보다 적으면 입금하지 않음
        if (currentCash < depositAmount)
        {
            Debug.LogWarning("Cash가 부족합니다.");
            UIManager.Instance.InsufficientWindow();
            return;
        }

        // 입금 금액을 PlayerBalance에 추가
        float currentBalance = DataManager.Instance.LoadPlayerBalance();
        currentBalance += depositAmount;
        DataManager.Instance.SaveBalance(currentBalance);

        // Cash에서 입금 금액을 차감
        currentCash -= depositAmount;
        DataManager.Instance.SaveCash(currentCash);

        balanceDisplay.UpdateBalanceText(currentBalance);
        cashDisplay.UpdateCashText(currentCash);
        UIManager.Instance.ReturnIntro();
    }
}
