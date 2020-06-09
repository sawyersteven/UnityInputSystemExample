using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    [SerializeField]
    private Wheel wheel;

    private Controls controls;

    private void Awake()
    {
        controls = new Controls();
        controls.Main.OpenWheel.performed += _ => wheel.Open();
        controls.Main.Enable();
    }
}
