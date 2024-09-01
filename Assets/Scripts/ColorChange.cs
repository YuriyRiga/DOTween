using UnityEngine;
using DG.Tweening;

public class ColorChange : MonoBehaviour
{
    [SerializeField] private Material _material;
    [SerializeField] private Color _color;
    [SerializeField] private float _duration;
    [SerializeField] private int _repeats;
    [SerializeField] private LoopType _loopType;

    private Color _originalColor = Color.red;

    private void Start()
    {
        _material.color = _originalColor;

        Sequence sequence = DOTween.Sequence();

        sequence.Append(_material.DOColor(_color, _duration));
        sequence.Append(_material.DOColor(_originalColor, _duration));
        sequence.SetEase(Ease.Linear);
        sequence.SetLoops(_repeats, _loopType);
    }
}
