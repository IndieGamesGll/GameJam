using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaterCklickerWithTimer : MonoBehaviour
{


    private float Seconds = 60;
    private bool TimerStoped = false;
    [SerializeField] private Text Timer;
    [SerializeField] private GameObject WinText, GameOverText;
    [SerializeField] private GameObject WaterPlane;
    [SerializeField] private GameObject WaterParticle;

    void Update()
    {
        if (!TimerStoped)
        {
            Seconds -= Time.deltaTime;
        }
        if (Seconds >= 0)
        {
            Debug.Log("Mtav");
            Timer.text = Mathf.Round(Seconds).ToString();

        }
        if (Seconds <= 0)
        {
            TimerStoped = true;
            GameOver();
        }
        if (WaterPlane.transform.position.y <= -1.25)
        {
            WaterParticle.SetActive(false);
            Win();
        }
        
            
    }
    public void GameOver()
    {
        Debug.Log("Game Over");
        GameOverText.SetActive(true);
    }
    public void Win()
    {
        TimerStoped = true;
        Debug.Log("Game Won");
        WinText.SetActive(true);

    }
    public void Click()
    {

        Vector3 Offset = new Vector3(0, -0.01f, 0);
        WaterPlane.transform.Translate(Offset);
    }
}