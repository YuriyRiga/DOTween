using DG.Tweening;
using UnityEngine;

public class SuperCube : Objects
{
    [SerializeField] private Vector3 _position;
    [SerializeField] private Vector3 _rotation;
    [SerializeField] private float _scale;

    protected override void Start()
    {
        SetTween(transform.DOMove(_position, Duration));
        base.Start();
        SetTween(transform.DORotate(_rotation, Duration, RotateMode.FastBeyond360));
        base.Start();
        SetTween(transform.DOScale(Vector3.one * _scale, Duration));
        base.Start();
    }
}
