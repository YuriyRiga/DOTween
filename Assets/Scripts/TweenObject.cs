using DG.Tweening;
using UnityEngine;

public abstract class TweenObject : MonoBehaviour
{
    [SerializeField] private float _duration;
    [SerializeField] private int _repeats;
    [SerializeField] private LoopType _loopType;

    protected float Duration => _duration;
    
    protected void AnimateLoop(Tween tween)
    {
        tween.SetEase(Ease.Linear);
        tween.SetLoops(_repeats, _loopType);
    }
}