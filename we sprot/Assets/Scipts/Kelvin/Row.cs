using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Row : MonoBehaviour
{
    private float timeInterval;
    private float randomValue;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    void startRotating()
    {
        StartCoroutine("Rotate");
    }
    private IEnumerator Rotate()
    {
        timeInterval = 0.025f;

        for (int i = 0; i < 30; i++)
        {
             if (transform.position.y <=  260 )
             {
                transform.position = new Vector2(transform.position.x, 1.75f);

             }
            transform.position = new Vector2(transform.position.x, transform.position.y - 0.25f);

            yield return new WaitForSeconds(timeInterval);
        }
        randomValue = Random.Range(60, 100);

        switch (randomValue % 3)
        {
            case 1:
                randomValue += 2;
                break;
            case 2:
                randomValue += 1;
                break;

        }
        for (int i = 0; i < randomValue; i++)
        {
            if (transform.position.y <= 260)
            {
                transform.position = new Vector2(transform.position.x, 1.75f);

            }
            transform.position = new Vector2(transform.position.x, transform.position.y - 0.25f);
            if (i > Mathf.RoundToInt(randomValue * 0.25f))
            {
                timeInterval = 0.05f;
            }
            yield return new WaitForSeconds(timeInterval);


        }

    }
}
