using UnityEngine;

public class SuperCube : TweenObject
{
    [SerializeField] private Vector3 _position;
    [SerializeField] private Vector3 _rotation;
    [SerializeField] private float _scale;

    protected override void Start()
    {
        AnimateMovement(_position);
        base.Start();
        AnimateRotation(_rotation);
        base.Start();
        AnimateScale(_scale);
        base.Start();
    }
}
