using UnityEngine;
using UnityEngine.UI;

public class ReturnButton : MonoBehaviour
{
    private void Start()
    {
        // 버튼을 클릭할 때 "ReturnActive" 메서드를 호출하는 이벤트 리스너 추가
        GetComponent<Button>().onClick.AddListener(ReturnActive);
    }

    private void ReturnActive()
    {
        UIManager.Instance.ReturnIntro();
    }
}
