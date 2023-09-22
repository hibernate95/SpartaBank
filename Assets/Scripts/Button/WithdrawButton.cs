using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WithdrawButton : MonoBehaviour
{
    private void Start()
    {
        // ��ư�� Ŭ���� �� "ShowDepositPanel" �޼��带 ȣ���ϴ� �̺�Ʈ ������ �߰�
        GetComponent<UnityEngine.UI.Button>().onClick.AddListener(ShowWithdrawPanel);
    }

    private void ShowWithdrawPanel()
    {
        UIManager.Instance.ShowWithdrawPanel();

    }
}
