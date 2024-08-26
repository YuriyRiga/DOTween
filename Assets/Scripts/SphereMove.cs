using DG.Tweening;
using UnityEngine;

public class Sphere : Objects
{
    [SerializeField] private Vector3 _position;

    protected override void Start()
    {
        SetTween(transform.DOMove(_position, Duration));
        base.Start();
    }
}
