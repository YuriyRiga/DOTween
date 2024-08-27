using UnityEngine;
using DG.Tweening;

public class CubeRotate : TweenObject
{
    [SerializeField] private Vector3 _rotation;

    protected override void Start()
    {
        AnimateRotation(_rotation);
        base.Start();
    }
}
