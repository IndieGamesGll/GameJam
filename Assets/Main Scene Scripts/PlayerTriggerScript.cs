using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTriggerScript : MonoBehaviour
{
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Trigger1")
        {
            //����������� � 1 �������� .SetActive(true)
        }
        if (other.tag == "Trigger2")
        {
            //����������� � 1 �������� .SetActive(true)
        }
        if (other.tag == "Trigger3")
        {
            //����������� � 1 �������� .SetActive(true)
        }
        if (other.tag == "EndLevel")
        {
            //����������� � 1 �������� .SetActive(true)
        }
    }
}
