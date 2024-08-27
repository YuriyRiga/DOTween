using UnityEngine;
using DG.Tweening;

public class ColorChange : TweenObject
{
    [SerializeField] private Material _material;
    [SerializeField] private Color _color;

    private Color _originalColor = Color.red;

    protected override void Start()
    {
        _material.color = _originalColor;

        Sequence sequence = DOTween.Sequence();

        sequence.Append(_material.DOColor(_color, Duration));
        sequence.Append(_material.DOColor(_originalColor, Duration));
        sequence.SetEase(Ease.Linear);
        sequence.SetLoops(Repeats,Loop);
    }
}
