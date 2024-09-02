using DG.Tweening;
using UnityEngine;

public class ToScale : TweenObject
{
    [SerializeField] private float _scale;

    private void Start()
    {
        AnimateScale();
    }

    private void AnimateScale()
    {
        Tween _tween = transform.DOScale(Vector3.one * _scale, Duration);
        AnimateLoop(_tween);
    }
}
