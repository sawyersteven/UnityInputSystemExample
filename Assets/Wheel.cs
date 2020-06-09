using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem;

public class Wheel : MonoBehaviour
{
    private Controls controls;

    public SpriteRenderer[] sprites;
    private SpriteRenderer selectedColorSprite;

    private void Awake()
    {
        controls = new Controls();
        controls.Wheel.CloseWheel.performed += _ => Close();
        controls.Wheel.SelectWheelSegment.performed += SelectSegment;
        selectedColorSprite = GetComponent<SpriteRenderer>();
    }

    private void Start()
    {
        sprites = GetComponentsInChildren<SpriteRenderer>(true).Where(x => x != selectedColorSprite).ToArray();
    }


    public void Open()
    {
        Debug.Log("Opening wheel");
        transform.Find("Selector").gameObject.SetActive(true);
        controls.Wheel.Enable();
    }

    public void Close()
    {
        Debug.Log("Closing wheel");
        transform.Find("Selector").gameObject.SetActive(false);
        controls.Wheel.Disable();
    }

    private void SelectSegment(InputAction.CallbackContext ctx)
    {
        Vector2 v = ctx.ReadValue<Vector2>();

        int i = 0;

        if (v.y == 1)
        {
            i = 0;
        }
        else if (v.x == 1)
        {
            i = 1;
        }
        else if (v.y == -1)
        {
            i = 2;
        }
        else if (v.x == -1)
        {
            i = 3;
        }
        selectedColorSprite.color = sprites[i].color;
    }
}
