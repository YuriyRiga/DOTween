using DG.Tweening;
using UnityEngine;

public class ObjectMove : TweenObject
{
    [SerializeField] private Vector3 _position;

    private void Start()
    {
        AnimateMovement();
    }

    private void AnimateMovement()
    {
        Tween _tween = transform.DOMove(_position, Duration);
        AnimateLoop(_tween);
    }
}
