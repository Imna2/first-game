using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject[] stages;
    // public Transform stageObj; //1
    //public Transform[] stars;  //1,1-2
    //public GameObject stars; //2

    public int stagenum = 0;
    int starnum;
    public int star;
    public static GameManager I;
    public Player player;
    public bool starReset = false;
    
    
    

    void Awake()
    {
        I = this;

    }

    void Start()
    {
       
        Starset(stages[0]);
    }
    void Update()
    {
       
        if (star == 0)
        {
            if(stagenum ==5)
            {
                Debug.Log("Clear");
                return;
            }
            stagenum++;
            Starset(stages[stagenum]);
            player.PlayerReset();
        }
    }

    public void Retry()
    {
        starnum = stages[stagenum].gameObject.transform.childCount; //스테이지 자식 오브젝트의 수

        //스테이지 자식오브젝트 배열로 가져와서 비활성화 > 활성화 시키기

        //stars = stageObj[stagenum].gameObject.GetComponentsInChildren<Transform>(); //1. []을 사용하는 인덱싱에 Transform 형식 적용불가능
        /*stars = stages[stagenum].GetComponentsInChildren<Transform>();              //1-2. 부모 오브젝트를 이용하여 자식 오브젝트를 가져오는 건 성공했으나 비활성화된 오브젝트의 활성화가 안됨.
        for(int i=1; i < stars.Length; i++)
        {
            Debug.Log(stars[i].name);
            stars[i].gameObject.SetActive(false);
            stars[i].gameObject.SetActive(true); //비활성화된 오브젝트의 활성화가 안됨...

        }
        Debug.Log("star의 수는"+starnum); 
        */

        //stars = stages[stagenum].FindGameObjectsWithTag("Star"); //2 멤버는 인스턴스 참조를 사용하여 액세스할 수 없습니다, 대신 형식이름을 사용하여 한정하세요.
        
        
        Starset(stages[stagenum]);
      

    }
    public void Starset(GameObject stage)
    {
        
        while (stage)
        if(stage.name == "Stage0")
            {
                
                stage.SetActive(true);

                star = 1;
                break;
            }
        else if (stage.name == "Stage1")
        {
                stages[stagenum - 1].SetActive(false);
                stage.SetActive(true);
                star = 2;
                break;
        }
            else if (stage.name == "Stage2")
            {
                stages[stagenum - 1].SetActive(false);
                stage.SetActive(true);
                star = 4;
                break;
            }
            else if (stage.name == "Stage3")
            {
                stages[stagenum - 1].SetActive(false);
                stage.SetActive(true);
                star = 3;
                break;
            }
            else if (stage.name == "Stage4")
            {
                stages[stagenum - 1].SetActive(false);
                stage.SetActive(true);
                star = 1;
                break;
            }
            else if (stage.name == "Stage5")
            {
                stages[stagenum - 1].SetActive(false);
                stage.SetActive(true);
                star = 8;
                break;
            }

    }

   
}
