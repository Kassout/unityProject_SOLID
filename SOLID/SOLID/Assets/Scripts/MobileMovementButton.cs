using UnityEngine;
using UnityEngine.EventSystems;

public class MobileMovementButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    [SerializeField]
    private PlayerMobileInput input;
    
    [SerializeField]
    private Vector2 direction;

    public void OnPointerDown(PointerEventData eventData)
    {
        input.GetMovementInput(direction);
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        input.ResetInput();
    }
}
