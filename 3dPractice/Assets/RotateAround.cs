using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RotateAround : MonoBehaviour
{
    private int score;

    void Start()
    {
        score = 0;
    }

    
    void Update()
    {
        transform.RotateAround(new Vector3(0, transform.position.y, 0), Vector3.up, Time.deltaTime * 10);
    }

    private void OnTriggerEnter(Collider other)
    {
        score++;
        GameObject.Find("Text").GetComponent<Text>().text = "Score: " + score;
    }
}
