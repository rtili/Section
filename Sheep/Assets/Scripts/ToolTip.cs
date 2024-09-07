using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToolTip : MonoBehaviour
{
    [SerializeField] private GameObject _descPanel;
    [SerializeField] private Text _descPanelText;
    [SerializeField] private float _raycastDistance;

    void Update()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit, _raycastDistance))
        {
            if (hit.collider.gameObject.TryGetComponent(out ObjectDescription desk))
            {
                _descPanel.SetActive(true);
                _descPanelText.text = desk.Description;
            }
        }
        else
        {
            _descPanel.SetActive(false);
        }
    }
}
