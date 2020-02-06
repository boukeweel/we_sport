using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Row : MonoBehaviour
{
    private float timeInterval;
    private float randomValue;

    public bool rowStopped;
    public static string stoppedSlot;

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
        print(transform.position.y);
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
            if (transform.position.y <= 186f)
                transform.position = new Vector3(transform.position.x, 1075f, transform.position.z);

            transform.position = new Vector3(transform.position.x, transform.position.y - 178f,transform.position.z);

            yield return new WaitForSeconds(timeInterval);
        }
        randomValue = Random.Range(60, 100);

        for (int i = 0; i < randomValue; i++)
        {
            if (transform.position.y <= 186f)
                transform.position = new Vector3(transform.position.x, 1075f, transform.position.z);

            transform.position = new Vector3(transform.position.x, transform.position.y - 178f, transform.position.z);
        }
            yield return new WaitForSeconds(timeInterval);

            if (transform.position.y == 185f)
            {
                
                stoppedSlot = "JumpingJacks";
            }
            else if (transform.position.y == 363f)
            {
                stoppedSlot = "Lunges";
            }
            else if (transform.position.y == 541f)
            {
                stoppedSlot = "Push Ups";
            }
            else if (transform.position.y == 719f)
            {
                stoppedSlot = "Sit Ups";
            }
            else if (transform.position.y == 897f)
            {
                stoppedSlot = "Planken";
            }
            else if (transform.position.y == 1075f)
            {
                print("werktdit?");
                stoppedSlot = "JumpingJacks";
            }
        yield return new WaitForSeconds(1.5f);
        wheelcan.SetActive(false);
        nextcan.SetActive(true);
        GameManager.alesuit = false;
        RondeText.ronde++;
    }
}
