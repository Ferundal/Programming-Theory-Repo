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
        GameOptions.Instance.PlayerNick = playerNick.text;
        SceneManager.LoadScene(1);
    }
}
