﻿using UnityEngine;
using UnityEngine.Events;

public class NPCEnemy : MonoBehaviour
{
    public UnityEvent<string> OnSpeak;
    public AudioSource audioSource;
    public string text = "I deal 10 physical damage    ( •̀ᴗ•́ )و ̑̑ ";

    public void GetHit()
    {
        OnSpeak?.Invoke(text);
        audioSource.Play();
        FindObjectOfType<Player>().ReceiveDamaged();
    }
}