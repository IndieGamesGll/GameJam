using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private bool IsWalking=false;
    private float RotationSpeed = 150;
    [SerializeField] private Animator PlayerAnimator;
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, 0, 0.05f);
            IsWalking = true;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, 0, -0.05f);
            IsWalking = true;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-0.05f, 0, 0);
            IsWalking = true;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(0.05f, 0, 0);
            IsWalking = true;
        }
        if(Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D))
        {
            IsWalking = false;
        }
        if (IsWalking)
        {
            PlayerAnimator.SetBool("Walk", true);
        }else if (!IsWalking)
        {
            PlayerAnimator.SetBool("Walk", false);
        }

        float yRotation = Input.GetAxis("Mouse X");

        transform.Rotate(0, yRotation * RotationSpeed * Time.deltaTime, 0);

    }
}
