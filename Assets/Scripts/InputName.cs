using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Name : MonoBehaviour
{
    public Text playerNameText; // �÷��̾� �̸��� ����� UI Text


    private void Start()
    {

        // PlayerPrefs���� �÷��̾� �̸��� �����ͼ� UI Text�� ����
        string playerName = PlayerPrefs.GetString("PlayerName", "DefaultName");
        playerNameText.text = playerName;
    }
}
