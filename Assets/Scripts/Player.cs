using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float _mouseSensevity = 100f;
    private CharacterController _controller;
    private float _speed = 5f;

    private void Start()
    {
        _controller = GetComponent<CharacterController>();
    }
    
    private void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * _mouseSensevity * Time.deltaTime;
        float moveZ = Input.GetAxis("Vertical") * _speed * Time.deltaTime;
        float moveX = Input.GetAxis("Horizontal") * _speed * Time.deltaTime;
        _controller.Move(transform.forward * moveZ + transform.right * moveX);
        transform.Rotate(Vector3.up * mouseX);
    }
}
