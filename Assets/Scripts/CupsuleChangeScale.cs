using DG.Tweening;
using UnityEngine;

public class CupsuleChangeScale : TweenObject
{
    [SerializeField] private float _scale;

    protected override void Start()
    {
        AnimateScale(_scale);
        base.Start();
    }
}
