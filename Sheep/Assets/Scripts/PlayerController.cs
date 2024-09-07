using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float _movementSpeed;
    private CharacterController _characterController;
    private Transform _cameraTransform;

    void Start()
    {
        _characterController = GetComponent<CharacterController>();
        _cameraTransform = Camera.main.transform;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        movement = _cameraTransform.forward * movement.z + _cameraTransform.right * movement.x;
        movement.y = 0;
        _characterController.Move(movement * _movementSpeed * Time.deltaTime);
    }
}
