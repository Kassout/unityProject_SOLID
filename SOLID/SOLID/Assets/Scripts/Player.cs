using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public Animator playerAnimator;
    
    private PlayerMovement _playerMovement;
    private PlayerRenderer _playerRenderer;
    private PlayerAIInteractions _playerAIInteractions;
    
    public GameObject ui_window;
    
    private Vector2 movementVector;

    private void Start()
    {
        _playerMovement = GetComponent<PlayerMovement>();
        _playerRenderer = GetComponent<PlayerRenderer>();
        _playerAIInteractions = GetComponent<PlayerAIInteractions>();
    }
    private void Update()
    {
        movementVector = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        movementVector.Normalize();
        if (Input.GetAxisRaw("Fire1") > 0)
        {
            _playerAIInteractions.Interact(_playerRenderer.IsSpriteFlipped);
        }
    }

    private void FixedUpdate()
    {
        MovePlayer(movementVector);
        if (movementVector.magnitude > 0)
        {
            ui_window.SetActive(false);
        }
        else
        {
            playerAnimator.SetBool("Walk", false);
        }
    }

    private void MovePlayer(Vector2 movementVector)
    {
        playerAnimator.SetBool("Walk", true);
        _playerMovement.MovePlayer(movementVector);

        _playerRenderer.RenderPlayer(movementVector);
    }

    public void ReceiveDamaged()
    {
        _playerRenderer.FlashRed();
    }


}
