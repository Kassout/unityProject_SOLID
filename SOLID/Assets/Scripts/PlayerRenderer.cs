using System.Collections;
using UnityEngine;

public class PlayerRenderer : MonoBehaviour
{
    [SerializeField]
    private SpriteRenderer playerRenderer;

    public bool IsSpriteFlipped => playerRenderer.flipX;

    public void RenderPlayer(Vector2 movement)
    {
        if (Mathf.Abs(movement.x) > 0.1f)
        {
            playerRenderer.flipX = Vector3.Dot(transform.right, movement) < 0;   
        }
    }

    public void FlashRed()
    {
        StopAllCoroutines();
        StartCoroutine(FlashRedCoroutine());
    }
    
    private IEnumerator FlashRedCoroutine()
    {
        playerRenderer.color = Color.red;
        yield return new WaitForSeconds(0.1f);
        playerRenderer.color = Color.white;
    }
}
