using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamController : MonoBehaviour
{
    [SerializeField] private float _mouseSens;
    [SerializeField] private GameObject _player;

    private void Update()
    {
        transform.Rotate(-Input.GetAxis("Mouse Y") * _mouseSens, 0, 0);
        _player.transform.Rotate(0, Input.GetAxis("Mouse X") * _mouseSens, 0);
    }
}
