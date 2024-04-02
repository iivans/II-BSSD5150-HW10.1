using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class MenuController : MonoBehaviour
{
    [SerializeField] TMP_InputField playerNameInputField;

    void Start()
    {
        // Load player's name from PlayerPrefs and update UI
        string playerName = PlayerPrefs.GetString("PlayerName", "Enter Player Name");
        playerNameInputField.text = playerName;

    }

    public void SaveOptions()
    {
        // Save player name to PlayerPrefs
        string playerName = playerNameInputField.text;
        PlayerPrefs.SetString("PlayerName", playerName);
    }

    public void RegisterName()
    {
        string playerName = playerNameInputField.text;
        PlayerPrefs.SetString("PlayerName", playerName);
    }

    public void OpenOptions()
    {
        SceneManager.LoadScene("Options", LoadSceneMode.Single);
    }

    public void OpenMenu()
    {
        SceneManager.LoadScene("Menu", LoadSceneMode.Single);
    }

    public void OpenGame()
    {
        SceneManager.LoadScene("Game", LoadSceneMode.Single);
    }
}
