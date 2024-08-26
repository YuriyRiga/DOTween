using DG.Tweening;
using UnityEngine;

public abstract class Objects : MonoBehaviour
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

    protected void SetTween(Tween tween)
    {
        _tween = tween;
    }
}