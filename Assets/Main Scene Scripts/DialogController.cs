using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DialogController : MonoBehaviour
{
    
    public void Dialog1Ends()
    {
        //�������� MiniGame1Scene �� ���������� ��������
        SceneManager.LoadScene("MiniGame1Scene");
    }
    public void Dialog2Ends()
    {
        //�������� MiniGame2Scene �� ���������� ��������
        SceneManager.LoadScene("MiniGame2Scene");
    }
    public void Dialog3Ends()
    {
        //�������� MiniGame3Scene �� ���������� ��������
        SceneManager.LoadScene("MiniGame3Scene");
    }
    public void GameEnds()
    {

    }
}
