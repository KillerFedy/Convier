using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLook : MonoBehaviour
{
    private float _mouseSensevity = 100f;
    private float _xRotation = 0;
    
    private void Update()
    {
        float mouseY = Input.GetAxis("Mouse Y") * _mouseSensevity * Time.deltaTime;
        _xRotation -= mouseY;
        _xRotation = Mathf.Clamp(_xRotation, -90f, 90f);
        transform.localRotation = Quaternion.Euler(_xRotation, 0, 0);
    }
}
