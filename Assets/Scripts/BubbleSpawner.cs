using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleSpawner : MonoBehaviour
{
    public GameObject bubblePrefab;
    public float spawnSecs = 1.0f;
    public float minBubbleSize = 0.01f;
    public float maxBubbleSize = 1.0f;

    private float spawnTracker = 0.0f;

    private Vector3 curPoint;



    void Start()
    {
        
    }

   
    void Update()
    {
        spawnTracker += Time.deltaTime;

        while (spawnTracker > spawnSecs)
        {
            spawnTracker -= spawnSecs;
            AddBubble();
        }
    }

     void AddBubble()
     {
         var screenBottomRandom = new Vector3(Random.Range(-Screen.width, Screen.width), Screen.height + (Screen.height/2), Camera.main.transform.position.z);
         var spawnPoint = Camera.main.ScreenToWorldPoint(screenBottomRandom);
         spawnPoint = new Vector3(spawnPoint.x, spawnPoint.y, 0.0f);

         GameObject newObj = Instantiate(bubblePrefab, spawnPoint, Quaternion.identity, transform);

        float scale = Random.Range(minBubbleSize, maxBubbleSize);
        newObj.transform.localScale = new Vector3(scale, scale, scale);

    }


}
