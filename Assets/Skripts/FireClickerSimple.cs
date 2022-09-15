using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FireClickerSimple : MonoBehaviour
{
    [SerializeField] private ParticleSystem Fire;
    [SerializeField] private ParticleSystem Spark;
    [SerializeField] private GameObject WinText, GameOverText;
    private bool GameStoped = false;

    void Start()
    {
        Fire.GetComponent<ParticleSystem>();
        Spark.GetComponent<ParticleSystem>();
    }


    void FixedUpdate()
    {
        if (!GameStoped)
        {
            Fire.startSize += 0.005f;
            Fire.startLifetime += 0.0025f;
            Fire.startSpeed += 0.00255f;
        }
        if (Fire.startSize >= 6)
        {
            GameOver();
        }
        if (Fire.startSize <= 0.05f)
        {
            Win();
            Spark.startSize = 0;
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
        Debug.Log("Game Won");
        WinText.SetActive(true);
        GameStoped = true;
    }
    public void Click()
    {
        Fire.startSize -= 0.1f;
        Fire.startLifetime -= 0.05f;
        Fire.startSpeed -= 0.05f;

        //Spark.startSpeed -= 0.025f;
        //Spark.startLifetime -= 0.025f;
    }
    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
