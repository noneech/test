using UnityEngine;

public class FirstPersonCamera : IRotateCamera
{
    private Transform _camera;
    private Transform _body;
    private float _rotationSpeed;
    private IInputSystem _inputSystem;

    public FirstPersonCamera(Transform camera, Transform body, PlayerConfig config, IInputSystem inputSystem)
    {
        _camera = camera;
        _body = body;
        _rotationSpeed = config.RotationSpeed;
        _inputSystem = inputSystem;
    }

    public void RotateCamera()
    {
        Vector3 rotation = _inputSystem.GetRotationInput();

        _camera.Rotate(rotation.y * -_rotationSpeed * Vector3.right * Time.fixedDeltaTime);
        _body.Rotate(rotation.x * _rotationSpeed * Vector3.up * Time.fixedDeltaTime);
    }
}
