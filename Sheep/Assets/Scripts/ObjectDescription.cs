using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDescription : MonoBehaviour
{
    [SerializeField] private string _description;
    public string Description => _description;
}
