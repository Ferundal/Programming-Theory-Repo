using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NameLoader : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.GetComponent<TextMeshProUGUI>().text = GameOptions.Instance.PlayerNick;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
