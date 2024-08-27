using DG.Tweening;
using UnityEngine;

public abstract class TweenObject : MonoBehaviour
{
    [SerializeField] private float _duration;
    [SerializeField] private int _repeats;
    [SerializeField] private LoopType _loopType;

    private Tween _tween;

    public float Duration => _duration;
    public int Repeats => _repeats;
    public LoopType Loop => _loopType;

    protected virtual void Start()
    {
        _tween.SetEase(Ease.Linear);
        _tween.SetLoops(_repeats, _loopType);
    }

    protected void AnimateMovement(Vector3 position)
    {
        _tween = transform.DOMove(position, _duration);
    }

    protected void AnimateRotation(Vector3 rotation)
    {
        _tween = transform.DORotate(rotation, _duration, RotateMode.FastBeyond360);
    }

    protected void AnimateScale(float scale)
    {
        _tween = transform.DOScale(Vector3.one * scale, _duration);
    }
}