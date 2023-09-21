using UnityEngine;

public class GameManager : MonoBehaviour
{
    // ���� �Ŵ����� �ν��Ͻ�
    private static GameManager instance;

    // ���� �Ŵ����� �ν��Ͻ��� ��ȯ�ϴ� ������Ƽ
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

    // �ٸ� �Ŵ��� Ŭ�������� ���⿡ �߰�
    private DataManager dataManager;
    private UIManager uiManager;
    

    // �� �Ŵ��� Ŭ������ ���� ������Ƽ
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

            // �� �Ŵ��� Ŭ������ �ʱ�ȭ
            dataManager = new DataManager();
            uiManager = new UIManager();
           

            // �� �Ŵ��� Ŭ������ �ʱ�ȭ �޼��� ȣ��
            dataManager.Init();
            uiManager.Init();
           
        }
    }

    // ���� �޴����� ��Ÿ ���� �� ���� ��� �߰�
}

