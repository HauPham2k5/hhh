using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public PlayerData playerData;
    void Start()
    {
        if (playerData == null)
        {
            playerData = ScriptableObject.CreateInstance<PlayerData>();

            playerData.playerLevel = 0;

            playerData.playerScore = 0;
        }
        else
        {
            LoadPlayerData();
        }
    }

    // Update is called once per frame
    void LoadPlayerData()
    {
        if (PlayerPrefs.HasKey("PlayerLevel"))
        {
            playerData.playerLevel = PlayerPrefs.GetInt("PlayerLevel");
            playerData.playerLevel = PlayerPrefs.GetInt("PlayerScore");
            Debug.Log("PlayerLevel" + playerData.playerLevel);
            Debug.Log("PlayerLevel" + playerData.playerScore);
        }
        else
        {
            playerData.playerLevel = 0;
            playerData.playerScore = 0;
        }
    }
}
