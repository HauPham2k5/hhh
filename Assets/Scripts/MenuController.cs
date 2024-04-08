using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject menuCanvas;
    public GameObject menuTrangPhuc;
    public PlayerData playerData;
    public Text Level;
    public Text Score;
    void Start()
    {
        HideMenu();
        LoadPlayerData();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (menuCanvas.activeSelf)
            {
                HideMenu();
            }
            else
            {
                ShowMenu();
            }
        }
    }

    void ShowMenu()
    {
        menuCanvas.SetActive(true);
        Time.timeScale = 0f; // Dừng thời gian trong trò chơi khi hiển thị menu
    }

    void HideMenu()
    {
        menuCanvas.SetActive(false);
        menuTrangPhuc.SetActive(false);
        Time.timeScale = 1f; // Khôi phục thời gian khi ẩn menu
    }
    void LoadPlayerData()
    {
        if (PlayerPrefs.HasKey("PlayerLevel"))
        {
            playerData.playerLevel = PlayerPrefs.GetInt("PlayerLevel");
            playerData.playerScore = PlayerPrefs.GetInt("PlayerScore");
            Level.text = "Level:" + (playerData.playerLevel).ToString();
            Score.text = "Score:" + (playerData.playerScore).ToString();
            Debug.Log("PlayerLevel" + playerData.playerLevel);
            Debug.Log("PlayerScore" + playerData.playerScore);
        }
        else
        {
            playerData.playerLevel = 0;
            playerData.playerScore = 0;
        }

    }
}
