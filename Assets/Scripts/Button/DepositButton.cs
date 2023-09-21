using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DepositButton : MonoBehaviour
{
    private UIManager uiManager;

    private void Start()
    {
        // UIManager에 대한 참조 가져오기
        uiManager = GameManager.Instance.GetUIManager();
    }

    // 눌리면 호출될 메서드 (예: 버튼 클릭 이벤트에서 호출)
    public void OnDepositButtonClick()
    {
        // UIManager의 ShowDepositPanel 메서드 호출
        uiManager.ShowDepositPanel();
    }
}
