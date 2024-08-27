using DG.Tweening;
using UnityEngine;

public class SphereMove : TweenObject
{
    [SerializeField] private Vector3 _position;

    protected override void Start()
    {
        AnimateMovement(_position);
        base.Start();
    }
}
