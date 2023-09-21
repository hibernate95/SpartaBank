using UnityEngine;

public class GameManager : MonoBehaviour
{
    // 게임 매니저의 인스턴스
    private static GameManager instance;

    // 게임 매니저의 인스턴스를 반환하는 프로퍼티
    public static GameManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<GameManager>();

                if (instance == null)
                {
                    GameObject go = new GameObject("GameManager");
                    instance = go.AddComponent<GameManager>();
                }
            }
            return instance;
        }
    }

    // 다른 매니저 클래스들을 여기에 추가
    private DataManager dataManager;
    private UIManager uiManager;
    

    // 각 매니저 클래스에 대한 프로퍼티
    public DataManager Data { get { return dataManager; } }
    public UIManager UI { get { return uiManager; } }
   

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);

            // 각 매니저 클래스를 초기화
            dataManager = new DataManager();
            uiManager = new UIManager();
           

            // 각 매니저 클래스의 초기화 메서드 호출
            dataManager.Init();
            uiManager.Init();
           
        }
    }

    // 게임 메니저의 기타 로직 및 관리 기능 추가
}

