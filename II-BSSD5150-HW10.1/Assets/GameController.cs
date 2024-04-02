using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameController : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI computerChoice;
    [SerializeField] TextMeshProUGUI resultText; // New text box for displaying game result
    [SerializeField] TextMeshProUGUI rockButtonLabel;

    string[] choices = new string[] { "Rock", "Paper", "Scissors" };

    void Start()
    {
        ResetGame();

        // Retrieve player's name from PlayerPrefs and display it along with the result
        string playerName = PlayerPrefs.GetString("PlayerName", "Player");
        DisplayResult("Welcome, " + playerName);

        UpdateRockButtonText();
    }

    public void RPSClicked(string userChoice)
    {
        int randomIndex = Random.Range(0, choices.Length);
        string randomChoice = choices[randomIndex];
        computerChoice.text = randomChoice;
        CheckWinner(userChoice, randomChoice);
    }

    private void CheckWinner(string p1, string p2)
    {
        string playerName = PlayerPrefs.GetString("PlayerName", "Player");

        if (string.Equals(p1, p2))
        {
            DisplayResult("Draw");
        }
        else if ((string.Equals(p1, "Rock") && string.Equals(p2, "Scissors")) ||
                 (string.Equals(p1, "Paper") && string.Equals(p2, "Rock")) ||
                 (string.Equals(p1, "Scissors") && string.Equals(p2, "Paper")))
        {
            DisplayResult(playerName + " Wins");
        }
        else
        {
            DisplayResult("Computer Wins");
        }
    }

    public void ResetGame()
    {
        computerChoice.text = "";
        resultText.text = "";
    }

    public void UpdateRockButtonText()
    {
        int selectedChoice = PlayerPrefs.GetInt("RockChoice", 0);
        UpdateButtonChoice(selectedChoice);
    }

    private void UpdateButtonChoice(int selectedChoice)
    {
        string buttonText = choices[selectedChoice];
        rockButtonLabel.text = buttonText; // Update the button label text
    }

    private void DisplayResult(string message)
    {
        string playerName = PlayerPrefs.GetString("PlayerName", "Player");
        resultText.text = message + "\n" + "Player: " + playerName;
    }
}
