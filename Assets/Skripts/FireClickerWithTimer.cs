using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FireClickerWithTimer : MonoBehaviour
{


    private float Seconds = 25;
    private bool TimerStoped = false;
    [SerializeField] private Text Timer;
    [SerializeField] private ParticleSystem Fire;
    [SerializeField] private ParticleSystem Spark;
    [SerializeField] private GameObject WinText, GameOverText;

    void Start()
    {
        Fire.GetComponent<ParticleSystem>();
        Spark.GetComponent<ParticleSystem>();
    }


    void Update()
    {
        if (!TimerStoped)
        {
            Seconds -= Time.deltaTime;
        }
        if (Seconds >= 0)
        {

            Timer.text = Mathf.Round(Seconds).ToString();

        }
        if (Seconds <= 0)
        {
            TimerStoped = true;
            GameOver();
        }
        if (Fire.startSize <= 0)
        {
            Win();
            Spark.startSize = 0;

        }
    }
    public void GameOver()
    {
        Debug.Log("Game Over");
        GameOverText.SetActive(true);
        //Invoke(nameof(RestartLevel),2f);
    }
    public void Win()
    {
        TimerStoped = true;
        Debug.Log("Game Won");
        WinText.SetActive(true);

    }
    public void Click()
    {
        Fire.startSize -= 0.05f;
        Fire.startLifetime -= 0.025f;
        Fire.startSpeed -= 0.025f;

        Spark.startSpeed -= 0.025f;
        Spark.startLifetime -= 0.025f;
    }
    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}