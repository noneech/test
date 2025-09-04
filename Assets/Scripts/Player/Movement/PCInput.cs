using UnityEngine;

public class PCInput : IInputSystem
{
    private readonly string _horizontal = "Horizontal";
    private readonly string _vertical = "Vertical";
    private readonly string _mouseX = "Mouse X";
    private readonly string _mouseY = "Mouse Y";

    public bool IsClick()
    {
        return Input.GetMouseButtonDown(0);
    }

    public Vector3 GetMoveInput()
    {
        float horizontalInput = Input.GetAxisRaw(_horizontal);
        float verticalInput = Input.GetAxisRaw(_vertical);

        return new Vector3(horizontalInput, 0, verticalInput);
    }

    public Vector3 GetRotationInput()
    {
        float horizontalRotation = Input.GetAxis(_mouseX);
        float verticalRotation = Input.GetAxisRaw(_mouseY);

        return new Vector3(horizontalRotation, verticalRotation, 0);
    }
}
