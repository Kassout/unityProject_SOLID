using System;
using UnityEngine;

public class PlayerMobileInput : MonoBehaviour, IPlayerInput
{
    public Vector2 MovementInput { get; private set; }
    public event Action OnInteractEvent;

    public void GetMovementInput(Vector2 direction)
    {
        MovementInput = direction;
    }

    public void InteractInput()
    {
        OnInteractEvent?.Invoke();
    }

    public void ResetInput()
    {
        MovementInput = Vector2.zero;
    }
}
