using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : MonoBehaviour
{
   
    public AudioClip getStar;

    private void Update()
    {
        if (this.transform.position.y < -15)
            StarRemove();
    }
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

    void StarRemove() //StartScene �������� �� ��ġ ����
    {
        Destroy(this.gameObject);
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
