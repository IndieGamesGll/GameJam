using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTriggerScript : MonoBehaviour
{
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Trigger1")
        {
            //Геймобджект с 1 диалогом .SetActive(true)
        }
        if (other.tag == "Trigger2")
        {
            //Геймобджект с 1 диалогом .SetActive(true)
        }
        if (other.tag == "Trigger3")
        {
            //Геймобджект с 1 диалогом .SetActive(true)
        }
        if (other.tag == "EndLevel")
        {
            //Геймобджект с 1 диалогом .SetActive(true)
        }
    }
}
