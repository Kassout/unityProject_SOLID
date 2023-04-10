using UnityEngine;

public class PlayerAnimations : MonoBehaviour
{
    [SerializeField] 
    private Animator playerAnimator;

    public void SetupAnimations(Vector2 movement)
    {
        if (movement.magnitude > 0)
        {
            playerAnimator.SetBool("Walk", true);
        }
        else
        {
            playerAnimator.SetBool("Walk", false);
        }
    }
}
