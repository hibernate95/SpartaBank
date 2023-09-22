using UnityEngine;
using UnityEngine.UI;

public class ReturnButton : MonoBehaviour
{
    private void Start()
    {
        // ��ư�� Ŭ���� �� "ReturnActive" �޼��带 ȣ���ϴ� �̺�Ʈ ������ �߰�
        GetComponent<Button>().onClick.AddListener(ReturnActive);
    }

    private void ReturnActive()
    {
        UIManager.Instance.ReturnIntro();
    }
}
