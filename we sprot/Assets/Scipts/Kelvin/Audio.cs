using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    public AudioClip otherClip;
    public static bool start = false;
    AudioSource m_MyAudioSource;
    private void Update()
    {
        if (start)
        {
            StartCoroutine("Startclip");
        }
         
    }
    private IEnumerator Startclip()
     {
        m_MyAudioSource = GetComponent<AudioSource>();
        m_MyAudioSource.Play();
        print("play");
        yield return new WaitForSeconds(m_MyAudioSource.clip.length);
        m_MyAudioSource.clip = otherClip;
        m_MyAudioSource.Play();
        print("play2");

    }

}
