using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class DialogThirdPerson : MonoBehaviour
{
    public GameObject PanelDialog;
    public Text Dialog;
    public string[] message;
    public bool DialogStart = false;
    void Start()
    {
        message[0] = "Привет! Вот твое третье задание!";
        message[1] = "Желаю Удачи!";
        PanelDialog.SetActive(false);
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "Player")
        {
            PanelDialog.SetActive(true);
            Dialog.text = message[0];
            DialogStart = true;

            //if (Input.GetKeyDown(KeyCode.R))
            //{
            //    Dialog.text = message[1];
            //}

        }
    }
    private void OnTriggerExit(Collider collision)
    {
        PanelDialog.SetActive(false);
        DialogStart = false;
    }



    void Update()
    {

        if (DialogStart == true)
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                Dialog.text = message[1];
            }
            if (Input.GetKeyDown(KeyCode.E))
            {
                SceneManager.LoadScene("Experience 3");
            }
        }
    }
}
