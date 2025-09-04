using UnityEngine;

public class PlayerLooking
{
    IRotateCamera _rotator;

    public PlayerLooking(IRotateCamera rotator)
    {
        _rotator = rotator;
    }

    public void SetRotator(IRotateCamera rotator)
    {
        _rotator = rotator;
    }

    public void RotateCamera()
    {
        if (_rotator != null) _rotator.RotateCamera();
    }
}
