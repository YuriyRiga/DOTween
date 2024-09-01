using UnityEngine;

public class SuperCube : TweenObject
{
    [SerializeField] private Vector3 _position;
    [SerializeField] private Vector3 _rotation;
    [SerializeField] private float _scale;

    private void Start()
    {
        AnimateMovement(_position);
        AnimateRotation(_rotation);
        AnimateScale(_scale);
    }
}
