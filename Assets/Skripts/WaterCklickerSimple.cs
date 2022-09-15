using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WaterCklickerSimple : MonoBehaviour
{


    [SerializeField] private GameObject WinText, GameOverText;
    [SerializeField] private GameObject WaterPlane;
    [SerializeField] private GameObject WaterParticle;


    private bool GameStoped = false;

    void FixedUpdate()
    {
        if (WaterPlane.transform.position.y >=3.3)
        {
            GameOver();
        }

        if (WaterPlane.transform.position.y <= -0.01)
        {
            WaterParticle.SetActive(false);
            Win();
        }
        if (!GameStoped)
        {
            Vector3 Offset = new Vector3(0, +0.001f, 0);
            WaterPlane.transform.Translate(Offset);
        }
    }
    public void GameOver()
    {
        Debug.Log("Game Over");
        GameOverText.SetActive(true);
        GameStoped = true;
    }
    public void Win()
    {
        GameStoped = true;
        Debug.Log("Game Won");
        WinText.SetActive(true);

    }
    public void Click()
    {

        Vector3 Offset = new Vector3(0, -0.02f, 0);
        WaterPlane.transform.Translate(Offset);
    }
    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}