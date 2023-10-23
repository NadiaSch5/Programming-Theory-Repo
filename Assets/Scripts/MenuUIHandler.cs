using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif


[DefaultExecutionOrder(1000)]
public class MenuUIHandler : MonoBehaviour
{
    [SerializeField] Text playerNameInput;

    // Class that sets the player name
   /* public void SetPlayerName()
    {
        PlayerDataHandler.Instance.playerName = playerNameInput.text;
    }
   */

    // This class will allow you to start the game
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    // This class will allow you to quit the game when pressing on the quit button
    public void QuitGame()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }

    // This class will allow you to return to the main menu screne when the exit button is clicked
    public void BacktoMenu()
    {
        SceneManager.LoadScene(0);
    }
 
}
