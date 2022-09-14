using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DialogController : MonoBehaviour
{
    
    public void Dialog1Ends()
    {
        //поменять MiniGame1Scene на правильное название
        SceneManager.LoadScene("MiniGame1Scene");
    }
    public void Dialog2Ends()
    {
        //поменять MiniGame2Scene на правильное название
        SceneManager.LoadScene("MiniGame2Scene");
    }
    public void Dialog3Ends()
    {
        //поменять MiniGame3Scene на правильное название
        SceneManager.LoadScene("MiniGame3Scene");
    }
    public void GameEnds()
    {

    }
}
