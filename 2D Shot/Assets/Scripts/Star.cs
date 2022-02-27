using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : MonoBehaviour
{
   
    public AudioClip getStar;

    
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            gameObject.SetActive(false);
            GameManager.I.star--;
            Debug.Log(GameManager.I.star);

            MusicManager.M.PlaySound(getStar);

          
        }
    }


    /* void Update()
    {

        if (GameManager.I.starReset)
        {
            Debug.Log("��Ÿ���� ����");
            gameObject.SetActive(true);

            GameManager.I.starReset =false;
        }
    }
    */
}
