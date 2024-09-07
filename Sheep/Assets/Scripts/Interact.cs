using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact : MonoBehaviour
{
    [SerializeField] private float _raycastDistance;

    void Update()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit, _raycastDistance))
        {
            if (hit.collider.gameObject.TryGetComponent(out IInteractable inter))
            {
                if (Input.GetMouseButtonDown(0))
                {
                    inter.MainAction();
                }
                if (Input.GetMouseButtonDown(1))
                {
                    inter.SecondaryAction();
                }
            }
        }
    }
}
