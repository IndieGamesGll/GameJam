using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private float _rotationSencetivity;
    private float _xRotation;
    [SerializeField] private Transform _cameraTramsform;
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private float _speed;
    
    [SerializeField] private Animator _playerAnimator;
    private bool _isWalking = false;
    void Update()
    {
        if (Input.GetMouseButton(1))
        {
            _xRotation -= Input.GetAxis("Mouse Y") * _rotationSencetivity;
            _xRotation = Mathf.Clamp(_xRotation, -60f, 60f);
            _cameraTramsform.localEulerAngles = new Vector3(_xRotation, 0f, 0f);

            transform.Rotate(0, Input.GetAxis("Mouse X") * _rotationSencetivity, 0);
        }

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            _isWalking = true;
        }
        else
        {
            _isWalking = false;
        }
        if (_isWalking)
        {
            _playerAnimator.SetBool("Walk", true);
        }
        else
        {
            _playerAnimator.SetBool("Walk", false);
        }
    }

    private void FixedUpdate()
    {
        Vector3 inputVector = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
        Vector3 speedVector = inputVector * _speed;

        Vector3 speedVectorRelativeToPlayer = transform.TransformVector(speedVector);

        _rigidbody.velocity = new Vector3(speedVectorRelativeToPlayer.x, _rigidbody.velocity.y, speedVectorRelativeToPlayer.z);
       // _rigidbody.velocity = new Vector3(speedVectorRelativeToPlayer.x, speedVectorRelativeToPlayer.y, speedVectorRelativeToPlayer.z);
    }
}
