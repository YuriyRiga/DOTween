using UnityEngine;

public class SphereMove : TweenObject
{
    [SerializeField] private Vector3 _position;

    private void Start()
    {
        AnimateMovement(_position);
    }
}
