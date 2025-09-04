using UnityEngine;

public class SetCameraRotator
{
    private FirstPersonCamera _firstPersonCamera;
    private PlayerLooking _playerLooking;
    private Player _player;

    public SetCameraRotator(PlayerLooking playerLooking, FirstPersonCamera firstPersonCamera)
    {
        _playerLooking = playerLooking;
        _firstPersonCamera = firstPersonCamera;
        _playerLooking.SetRotator(_firstPersonCamera);
    }
}
