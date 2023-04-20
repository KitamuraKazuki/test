using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockController : MonoBehaviour
{
    float fallSpeed;
    float rotSpeed;
    void Start()
    {
        this.fallSpeed = 0.01f + 0.1f * Random.value * Time.deltaTime;
        this.rotSpeed = 50.0f * Random.Range(-1f, 1f) * Time.deltaTime;
    }
    void Update()
    {
        transform.Translate(0, -fallSpeed, 0, Space.World);
        transform.Rotate(0, 0, rotSpeed);
        if (transform.position.y < -5.5f)
        {
            GameObject.Find("Canvas").GetComponent<UIController>().GameOver();
            Destroy(gameObject);
        }
    }
}
