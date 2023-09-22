using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DepositInputButton : MonoBehaviour
{
    public InputField depositInputField; // 입금 금액을 입력하는 Input Field
    public BalanceDisplay balanceDisplay; // BalanceDisplay 스크립트 참조
    public CashDisplay cashDisplay;

    private void Start()
    {
        // Deposit 버튼에 클릭 이벤트 리스너를 추가합니다.
        Button inputButton = GetComponent<Button>();
        inputButton.onClick.AddListener(PerformDeposit);
    }

    private void PerformDeposit()
    {
        // 입력된 입금 금액을 가져옵니다. 입력이 비어있을 경우 0으로 간주합니다.
        if (float.TryParse(depositInputField.text, out float depositAmount))
        {
            // 현재 PlayerBalance를 가져옵니다.
            float currentBalance = PlayerPrefs.GetFloat("PlayerBalance", 0f);

            float currentCash = PlayerPrefs.GetFloat("PlayerCash", 0f);

            // 현재 Cash가 입금 금액보다 적으면 입금하지 않음
            if (currentCash < depositAmount)
            {
                Debug.LogWarning("Cash가 부족합니다.");
                UIManager.Instance.InsufficientWindow();
                return;
            }

            // 입금 금액을 PlayerBalance에 추가합니다.
            currentBalance += depositAmount;
            DataManager.Instance.SaveBalance(currentBalance);

            // Cash에서 입금 금액을 차감합니다.
            currentCash -= depositAmount;
            DataManager.Instance.SaveCash(currentCash);


            // BalanceDisplay 스크립트의 업데이트 메서드를 호출하여 잔고 텍스트를 갱신합니다.
            balanceDisplay.UpdateBalanceText(currentBalance);
            cashDisplay.UpdateCashText(currentCash);
            UIManager.Instance.ReturnIntro();
        }
        else
        {
            Debug.LogWarning("입력된 금액을 올바르게 변환할 수 없습니다.");
        }
    }
}
