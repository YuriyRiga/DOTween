using DG.Tweening;
using UnityEngine;

public class ObjectRotate : TweenObject
{
    [SerializeField] private Vector3 _rotation;

    private void Start()
    {
        AnimateRotation();
    }

    private void AnimateRotation()
    {
        Tween _tween = transform.DORotate(_rotation, Duration, RotateMode.FastBeyond360);
        AnimateLoop(_tween);
    }
}
