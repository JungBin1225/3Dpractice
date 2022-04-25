using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBall : MonoBehaviour
{
    public GameObject ballPrefab;
    private float time;

    void Start()
    {
        time = 3.0f;
    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;

        if(time < 0)
        {
            GameObject ball = Instantiate(ballPrefab) as GameObject;
            time = 3.0f;
        }
    }
}
