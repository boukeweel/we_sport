using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Row : MonoBehaviour
{
    private float timeInterval;
    private float randomValue;

    public bool rowStopped;
    public string stoppedSlot;

    public GameObject wheelcan;
    public GameObject nextcan;
    // Start is called before the first frame update
    void Start()
    {
        rowStopped = true;
    }

    // Update is called once per frame
    void Update()
    {
    }
    public void startRotating()
    {
        stoppedSlot = "";
        StartCoroutine("Rotate");
    }
    private IEnumerator Rotate()
    {
        timeInterval = 0.09f;

        for (int i = 0; i < 30; i++)
        {
            if (transform.position.y <= -345f)
                transform.position = new Vector3(transform.position.x, 405,transform.position.z);

            transform.position = new Vector3(transform.position.x, transform.position.y - 150f,transform.position.z);

            yield return new WaitForSeconds(timeInterval);
        }
        randomValue = Random.Range(60, 100);

        for (int i = 0; i < randomValue; i++)
        {
            if (transform.position.y <= -345f)
                transform.position = new Vector3(transform.position.x, 405, transform.position.z);

            transform.position = new Vector3(transform.position.x, transform.position.y - 150f, transform.position.z);
        }
            yield return new WaitForSeconds(timeInterval);

            if (transform.position.y == -345f)
            {
                stoppedSlot = "Jumping Jack";
            }
            else if (transform.position.y == -195f)
            {
                stoppedSlot = "Lunges";
            }
            else if (transform.position.y == -45f)
            {
                stoppedSlot = "Push Ups";
            }
            else if (transform.position.y == 105f)
            {
                stoppedSlot = "Sit Ups";
            }
            else if (transform.position.y == 255f)
            {
                stoppedSlot = "Planken";
            }
            else if (transform.position.y == 405f)
            {
                stoppedSlot = "jumping jacks";
            }
        yield return new WaitForSeconds(1.5f);
        wheelcan.SetActive(false);
        nextcan.SetActive(true);
        RondeText.ronde++;
    }
}
