using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockSpawner : MonoBehaviour
{
    Camera cam;
    // Start is called before the first frame update
    public List<GameObject> rocks;
    float timeGap=1f;
    float nextSpawnTime;
    void Start()
    {
        cam = Camera.main;
        nextSpawnTime = Time.time;
        ScreenUtils.Initialize();
    }

    // Update is called once per frame
    void Update()
    {
        int count = GameObject.FindGameObjectsWithTag("Rock").Length;
        
        if(Time.time>nextSpawnTime && count<3)
        {
            int randIndx = Random.Range(0, 3);
            Instantiate(rocks[randIndx], Vector3.zero, Quaternion.identity);
            nextSpawnTime = Time.time + timeGap;
            Debug.Log(count);
        }
        
    }
}

