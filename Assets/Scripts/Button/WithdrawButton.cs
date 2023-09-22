using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WithdrawButton : MonoBehaviour
{
    private void Start()
    {
        // 버튼을 클릭할 때 "ShowDepositPanel" 메서드를 호출하는 이벤트 리스너 추가
        GetComponent<UnityEngine.UI.Button>().onClick.AddListener(ShowWithdrawPanel);
    }

    private void ShowWithdrawPanel()
    {
        UIManager.Instance.ShowWithdrawPanel();

    }
}
