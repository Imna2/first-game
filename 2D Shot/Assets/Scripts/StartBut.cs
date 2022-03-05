using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class StartBut : MonoBehaviour
{
    public GameObject startBut;

    public void LevelSceneLoad() //스테이지 씬을 불러온다 ( 일단 게임씬 )
    {
        SceneManager.LoadScene("GameScene");
    }
}
