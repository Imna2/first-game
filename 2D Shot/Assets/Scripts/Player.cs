using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    Rigidbody2D rigid;
   

    public bool isShot = false;

    public float power = 8f;

    Vector2 a = new Vector2(0, 10);
    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
    
    }

    // Update is called once per frame
    void Update()
    {
        // rigid.velocity = Vector2.up * power;
     /*if(!isShot && Input.GetButton("Fire1"))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector3 forwardPos = new Vector3(-mousePos.x, mousePos.y, 0);
            Vector3 playerPos = new Vector3(transform.position.x,transform.position.y,0); 
            Debug.DrawRay(playerPos,transform.forward*3,Color.green,0.5f);

        }
     */
       
        if (!isShot && Input.GetButtonUp("Fire1"))
        {
           
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            isShot = true;

            if (isShot)
            {
                Shot(mousePos);
               
            }

           
        }

      if(transform.position.y < -12 || transform.position.x < -6 || transform.position.x > 6)
        {
            transform.position = new Vector3(0, -7, 1);
            rigid.velocity = Vector2.zero;
            isShot = false;
            //만약 특정좌표를 넘어가면 해당 스테이지를 다시 불러오는 스크립트 작성하여야함.

            //GameManager.I.Starset(GameManager.I.stages[GameManager.I.stagenum]);
            //GameManager.I.Retry();
        }
    }

    void Shot(Vector3 mousePos)
    {
        Vector3 Pos = new Vector3(-mousePos.x, 1, 0);
        rigid.AddForce(Pos * power, ForceMode2D.Impulse);

    }

    public void PlayerReset()
    {
        rigid.velocity = Vector2.zero;
        gameObject.transform.position = new Vector3(0, -7, 0);
        isShot = false;

        
    }
}
