using DG.Tweening;
using UnityEngine;
using UnityEngine.EventSystems;

public class ScaleCard : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public float defaultSize;
    public float scaledSize;
    public float transitionSpeed;
    
    private RectTransform _rectTransform;

    void Start()
    {
        _rectTransform = GetComponent<RectTransform>();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        _rectTransform.DOScale(new Vector3(scaledSize, scaledSize, scaledSize), transitionSpeed);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        _rectTransform.DOScale(new Vector3(defaultSize, defaultSize, defaultSize), transitionSpeed);
    }
}
