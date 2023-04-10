using System;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public Vector2 MovementInput { get; private set; }

    public event Action OnInteractEvent;

    private void Update()
    {
        GetInteractInput();
        GetMovementInput();
    }

    private void GetMovementInput()
    {
        MovementInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        MovementInput.Normalize();
    }

    private void GetInteractInput()
    {
        if (Input.GetAxisRaw("Fire1") > 0)
        {
            OnInteractEvent?.Invoke();
        }
    }
}
