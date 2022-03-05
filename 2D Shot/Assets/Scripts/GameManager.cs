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
        starnum = stages[stagenum].gameObject.transform.childCount; //�������� �ڽ� ������Ʈ�� ��

        //�������� �ڽĿ�����Ʈ �迭�� �����ͼ� ��Ȱ��ȭ > Ȱ��ȭ ��Ű��

        //stars = stageObj[stagenum].gameObject.GetComponentsInChildren<Transform>(); //1. []�� ����ϴ� �ε��̿� Transform ���� ����Ұ���
        /*stars = stages[stagenum].GetComponentsInChildren<Transform>();              //1-2. �θ� ������Ʈ�� �̿��Ͽ� �ڽ� ������Ʈ�� �������� �� ���������� ��Ȱ��ȭ�� ������Ʈ�� Ȱ��ȭ�� �ȵ�.
        for(int i=1; i < stars.Length; i++)
        {
            Debug.Log(stars[i].name);
            stars[i].gameObject.SetActive(false);
            stars[i].gameObject.SetActive(true); //��Ȱ��ȭ�� ������Ʈ�� Ȱ��ȭ�� �ȵ�...

        }
        Debug.Log("star�� ����"+starnum); 
        */

        //stars = stages[stagenum].FindGameObjectsWithTag("Star"); //2 ����� �ν��Ͻ� ������ ����Ͽ� �׼����� �� �����ϴ�, ��� �����̸��� ����Ͽ� �����ϼ���.
        
        
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
