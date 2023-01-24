using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumberGuessingGame : MonoBehaviour
{

    public Text messageText;
    public InputField guessInput;
    public int computersNumber;
    public Button quitButton;

    // Start is called before the first frame update
    void Start()
    {
        quitButton.onClick.AddListener(QuitGame);
        quitButton.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        messageText.text = "I have picked a number bewteen 1 and 100." + "\n" + "Can you guess it?" 
            + "\n" + "Type your guessin the box below and click the Guess button.";
        computersNumber = Random.Range(1, 101);
    }

    public void GetGuess()
    {
        string guessString = guessInput.text;
        int guessInt = System.Convert.ToInt32(guessString);
        if (guessInt > computersNumber)
        {
            messageText.text = "Too high! Guess lower!";
        }
        else if (guessInt < computersNumber)
        {
            messageText.text = "Too low! Guess higher!";
        }
        else
        {
            messageText.text = "You guessed it! Click the Quit button to leave the game.";
            quitButton.gameObject.SetActive(true);
        }
    }

    public void QuitGame() 
    { 
        Application.Quit();
        Debug.Log("Game is exiting");
    }
}
