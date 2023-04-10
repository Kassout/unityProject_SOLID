using System;
using UnityEngine;

public interface IPlayerInput
{
    Vector2 MovementInput { get; }
    event Action OnInteractEvent;
}
