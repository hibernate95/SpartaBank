using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DepositButton : MonoBehaviour
{
    private void Start()
    {
        // 버튼을 클릭할 때 "ShowDepositPanel" 메서드를 호출하는 이벤트 리스너 추가
        GetComponent<UnityEngine.UI.Button>().onClick.AddListener(ShowDepositPanel);
    }

    private void ShowDepositPanel()
    {
        UIManager.Instance.ShowDepositPanel();
        
    }
}
