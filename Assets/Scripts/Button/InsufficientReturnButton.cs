using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InsufficientButton : MonoBehaviour
{
    private void Start()
    {
        // ��ư�� Ŭ���� �� "ReturnActive" �޼��带 ȣ���ϴ� �̺�Ʈ ������ �߰�
        GetComponent<Button>().onClick.AddListener(InsufficientDeactive);
    }

    private void InsufficientDeactive()
    {
        UIManager.Instance.ReturnInsufficient();
    }
}
