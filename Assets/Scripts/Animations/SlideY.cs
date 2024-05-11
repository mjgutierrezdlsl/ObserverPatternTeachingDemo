using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class SlideY : MonoBehaviour
{
    [SerializeField] float yPosition, duration = 0.5f;
    public void SlideToPosition()
    {
        transform.DOLocalMoveY(yPosition, duration).From(0).SetEase(Ease.InCubic);
    }
    public void SlideFromPosition()
    {
        transform.DOLocalMoveY(0, duration).From(yPosition).SetEase(Ease.OutCubic);
    }
}
