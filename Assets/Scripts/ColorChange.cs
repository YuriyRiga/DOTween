using UnityEngine;
using DG.Tweening;

public class ColorChange : TweenObject
{
    [SerializeField] private Material _material;
    [SerializeField] private Color _color;
    
    private Color _originalColor = Color.red;

    private void Start()
    {
        _material.color = _originalColor;
        AnimateColor();
    }

    private void AnimateColor()
    {
        Sequence sequence = DOTween.Sequence();

        sequence.Append(_material.DOColor(_color, Duration));
        sequence.Append(_material.DOColor(_originalColor, Duration));

        AnimateLoop(sequence);
    }
}
