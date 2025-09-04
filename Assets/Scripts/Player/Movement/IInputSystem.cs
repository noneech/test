using UnityEngine;

public interface IInputSystem
{
    public Vector3 GetMoveInput();

    public Vector3 GetRotationInput();

    public bool IsClick();
}
