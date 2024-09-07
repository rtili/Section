using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clamp : MonoBehaviour, IInteractable
{
    [SerializeField] private GameObject[] _screws;
    [SerializeField] private GameObject _menu;

    public void MainAction()
    {
        foreach (var screw in _screws)
        {
            screw.GetComponent<Animator>().SetTrigger("Play");
        }
    }

    public void SecondaryAction()
    {
        _menu.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}
