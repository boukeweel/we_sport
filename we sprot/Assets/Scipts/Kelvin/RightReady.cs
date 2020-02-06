using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class RightReady : MonoBehaviour
{
    private Text m_TextComponent;
    public static  bool ispressed = false;
    public static bool isReady;
    public GameObject ready;
    // Start is called before the first frame update
    void Start()
    {
        m_TextComponent = GetComponent<Text>();
        ready.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightShift) && !ispressed)
        {
            m_TextComponent.text = "";
            ready.SetActive(true);
            isReady = true;
            ispressed = true;
        }
        else if (Input.GetKeyDown(KeyCode.RightShift) && ispressed)
        {
            m_TextComponent.text = "Press Rshift if your ready";
            ispressed = false;
            isReady = false;
            ready.SetActive(false);
        }
        if (ispressed == false)
        {
            m_TextComponent.text = "Press Rshift if your ready";
            ispressed = false;
            isReady = false;
            ready.SetActive(false);
        }
    }
}
