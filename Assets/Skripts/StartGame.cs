using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       //Time.timeScale = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        Time.timeScale = 0f;
    }
    public void ResumeTime()
    {
        Time.timeScale = 1f;
    }
}
