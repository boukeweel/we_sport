using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class RondeText : MonoBehaviour
{
    private Text m_TextComponent;
    public static float ronde = 0;

    // Start is called before the first frame update
    void Start()
    {
        m_TextComponent = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        m_TextComponent.text = "Round: " + ronde;
    }
}
