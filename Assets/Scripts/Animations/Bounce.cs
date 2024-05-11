using DG.Tweening;
using UnityEngine;

public class Bounce : MonoBehaviour
{
    [SerializeField] float duration = 0.5f;
    public void Show()
    {
        transform.DOScale(1f, duration).From(0f).SetEase(Ease.OutBounce);
    }
    public void Click(float fromSize)
    {
        transform.DOScale(1f, duration).From(fromSize).SetEase(Ease.OutBounce);
    }
    public void Hide()
    {
        transform.DOScale(0f, duration).From(1f).SetEase(Ease.InBounce);
    }
}
