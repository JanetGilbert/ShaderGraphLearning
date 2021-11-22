using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bubble : MonoBehaviour
{
    public float bubbleSpeedMax = 5.0f;
    public float bubbleSpeedMin = 1.0f;

    private float bubbleSpeed;
    private float topY;

    void Start()
    {
        bubbleSpeed = Random.Range(bubbleSpeedMin, bubbleSpeedMax);

        var screenTop = new Vector3(0.0f, -(Screen.height + (Screen.height / 2)), Camera.main.transform.position.z);
        var spawnPoint = Camera.main.ScreenToWorldPoint(screenTop);
        topY = spawnPoint.y;
    }

    
    void Update()
    {
        transform.position += Vector3.up * bubbleSpeed * Time.deltaTime;

        if (transform.position.y > topY)
        {
            Destroy(gameObject);
        }
    }
}
