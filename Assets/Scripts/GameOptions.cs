using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOptions : MonoBehaviour
{
    public static GameOptions Instance { get; private set; } = null;
    // Start is called before the first frame update

    private string b_PlayerNick = "NoName";

    // ENCAPSULATION
    public string PlayerNick
    {
        get
        {
            return b_PlayerNick;
        }
        set
        {
            if (value.Length > 10)
            {
                b_PlayerNick = new string(value.ToCharArray(), 0, 10);
            }
            else
            {
                b_PlayerNick = value;
            }
        }
    }

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(this.gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(this.gameObject);
    }
}
