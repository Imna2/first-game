using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class StartBut : MonoBehaviour
{
    public GameObject startBut;

    public void LevelSceneLoad() //�������� ���� �ҷ��´� ( �ϴ� ���Ӿ� )
    {
        SceneManager.LoadScene("GameScene");
    }
}
