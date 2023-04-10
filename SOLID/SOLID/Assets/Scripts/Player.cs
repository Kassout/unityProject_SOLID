using UnityEngine;

public class Player : MonoBehaviour
{
    private PlayerMovement _playerMovement;
    private PlayerRenderer _playerRenderer;
    private PlayerAIInteractions _playerAIInteractions;
    private IPlayerInput _playerInput;
    private PlayerAnimations _playerAnimations;

    public UIController uiController;

    private void Start()
    {
        _playerAnimations = GetComponent<PlayerAnimations>();
        _playerMovement = GetComponent<PlayerMovement>();
        _playerRenderer = GetComponent<PlayerRenderer>();
        _playerAIInteractions = GetComponent<PlayerAIInteractions>();
        _playerInput = GetComponent<IPlayerInput>();

        _playerInput.OnInteractEvent += () => _playerAIInteractions.Interact(_playerRenderer.IsSpriteFlipped);
    }

    private void FixedUpdate()
    {
        _playerMovement.MovePlayer(_playerInput.MovementInput);
        _playerRenderer.RenderPlayer(_playerInput.MovementInput);
        _playerAnimations.SetupAnimations(_playerInput.MovementInput);
        
        if (_playerInput.MovementInput.magnitude > 0)
        {
            uiController.ToggleUI(false);
        }
    }
    
    public void ReceiveDamaged()
    {
        _playerRenderer.FlashRed();
    }


}
