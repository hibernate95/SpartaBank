using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DepositButton : MonoBehaviour
{
    private void Start()
    {
        // ��ư�� Ŭ���� �� "ShowDepositPanel" �޼��带 ȣ���ϴ� �̺�Ʈ ������ �߰�
        GetComponent<UnityEngine.UI.Button>().onClick.AddListener(ShowDepositPanel);
    }

    private void ShowDepositPanel()
    {
        UIManager.Instance.ShowDepositPanel();
        
    }
}
