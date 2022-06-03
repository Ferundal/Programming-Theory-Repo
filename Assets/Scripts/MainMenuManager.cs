using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    [SerializeField] private TMP_InputField playerNick;


    public void StartGame()
    {
        Debug.Log("Field value: " + playerNick.text);
        // ENCAPSULATION
        GameOptions.Instance.PlayerNick = playerNick.text;
        Debug.Log("Game Options value: " + GameOptions.Instance.PlayerNick);
        SceneManager.LoadScene(1);
    }
}
