using UnityEngine;

public class PlayerAnimations : MonoBehaviour
{
    [SerializeField] 
    private Animator playerAnimator;

    private static readonly int Walk = Animator.StringToHash("Walk");

    public void SetupAnimations(Vector2 movement)
    {
        playerAnimator.SetBool(Walk, movement.magnitude > 0);
    }
}
