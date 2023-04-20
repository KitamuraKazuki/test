using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceScroller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate (0, -0.01f, 0);
        if (transform.position.y < -19.6f) 
        {
            transform.position = new Vector3 (0, 19.6f, 0);
        }
    }
}
