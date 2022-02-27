using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject[] stages;
    public GameObject[] stars;
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
        starnum = stages[stagenum].gameObject.transform.childCount;
        
        //스테이지 자식오브젝트 배열로 가져와서 비활성화 > 활성화 시키기
        
        stages[stagenum].SetActive(false);
        
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
