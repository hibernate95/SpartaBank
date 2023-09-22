using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InsufficientButton : MonoBehaviour
{
    private void Start()
    {
        // 버튼을 클릭할 때 "ReturnActive" 메서드를 호출하는 이벤트 리스너 추가
        GetComponent<Button>().onClick.AddListener(InsufficientDeactive);
    }

    private void InsufficientDeactive()
    {
        UIManager.Instance.ReturnInsufficient();
    }
}
