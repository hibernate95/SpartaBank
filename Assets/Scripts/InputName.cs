using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Name : MonoBehaviour
{
    public Text playerNameText; // 플레이어 이름을 출력할 UI Text


    private void Start()
    {

        // PlayerPrefs에서 플레이어 이름을 가져와서 UI Text에 설정
        string playerName = PlayerPrefs.GetString("PlayerName", "DefaultName");
        playerNameText.text = playerName;
    }
}
