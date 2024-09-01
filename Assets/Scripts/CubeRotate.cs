using UnityEngine;

public class CubeRotate : TweenObject
{
    [SerializeField] private Vector3 _rotation;

    private void Start()
    {
        AnimateRotation(_rotation);
    }
}
