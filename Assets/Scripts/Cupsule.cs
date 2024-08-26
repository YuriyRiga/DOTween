using DG.Tweening;
using UnityEngine;

public class Cupsule : Objects
{
    [SerializeField] private float _scale;

    protected override void Start()
    {
        SetTween(transform.DOScale(Vector3.one * _scale, Duration));
        base.Start();
    }
}
