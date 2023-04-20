using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public GameObject explosionprefab; //爆発エフェクトのprefab

    // Update is called once per frame
    void Update()
    {
        transform.Translate (0, 0.2f, 0);
        if (transform.position.y > 5)
         { 
             Destroy (gameObject); 
         }
    }
    void OnTriggerEnter2D(Collider2D coll)
    {
        //衝突したときにスコアを更新する
        GameObject.Find("Canvas").GetComponent<UIController>().AddScore();

        //爆発エフェクトを生成
        GameObject effect = Instantiate(explosionprefab, transform.position, Quaternion.identity) as GameObject;
        Destroy(effect, 1.0f);
        Instantiate(explosionprefab, transform.position, Quaternion.identity);
        Destroy(coll.gameObject);
        Destroy(gameObject);
    }
}
