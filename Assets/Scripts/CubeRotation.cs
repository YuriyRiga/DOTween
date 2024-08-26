using UnityEngine;
using DG.Tweening;

public class Cube : Objects
{
    [SerializeField] private Vector3 _rotation;
    
    protected override void Start()
    {
        SetTween(transform.DORotate(_rotation, Duration, RotateMode.FastBeyond360));
        base.Start();
    }
}
