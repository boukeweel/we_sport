using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gamemode : MonoBehaviour
{
    private Text m_TextComponent;

    // Start is called before the first frame update
    void Start()
    {
        m_TextComponent = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        m_TextComponent.text = Row.stoppedSlot;
    }
}
