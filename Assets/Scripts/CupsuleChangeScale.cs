using UnityEngine;

public class CupsuleChangeScale : TweenObject
{
    [SerializeField] private float _scale;

    private void Start()
    {
        AnimateScale(_scale);
    }
}
