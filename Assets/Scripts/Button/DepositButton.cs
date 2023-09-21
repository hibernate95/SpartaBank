using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DepositButton : MonoBehaviour
{
    private UIManager uiManager;

    private void Start()
    {
        // UIManager�� ���� ���� ��������
        uiManager = GameManager.Instance.GetUIManager();
    }

    // ������ ȣ��� �޼��� (��: ��ư Ŭ�� �̺�Ʈ���� ȣ��)
    public void OnDepositButtonClick()
    {
        // UIManager�� ShowDepositPanel �޼��� ȣ��
        uiManager.ShowDepositPanel();
    }
}
