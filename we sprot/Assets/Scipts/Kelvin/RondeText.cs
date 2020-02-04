using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class RondeText : MonoBehaviour
{
    private TMP_Text m_TextComponent;
    private float ronde = 0;

    // Start is called before the first frame update
    void Start()
    {
        m_TextComponent = GetComponent<TMP_Text>();
        
    }

    // Update is called once per frame
    void Update()
    {
        m_TextComponent.text = "Ronde: " + ronde;
    }
}
