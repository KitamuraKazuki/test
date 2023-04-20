using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public GameObject explosionprefab; //�����G�t�F�N�g��prefab

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
        //�Փ˂����Ƃ��ɃX�R�A���X�V����
        GameObject.Find("Canvas").GetComponent<UIController>().AddScore();

        //�����G�t�F�N�g�𐶐�
        GameObject effect = Instantiate(explosionprefab, transform.position, Quaternion.identity) as GameObject;
        Destroy(effect, 1.0f);
        Instantiate(explosionprefab, transform.position, Quaternion.identity);
        Destroy(coll.gameObject);
        Destroy(gameObject);
    }
}
