using UnityEngine;

public class PlayerMovement
{
    private Transform _player;
    private float _speed;
    private IInputSystem _inputSystem;

    public PlayerMovement(Transform player, IInputSystem inputSystem, PlayerConfig config)
    {
        _player = player;
        _inputSystem = inputSystem;
        _speed = config.MoveSpeed;
    }

    public void Move()
    {
        Vector3 move = _inputSystem.GetMoveInput() * _speed;

        _player.Translate(move);
    }
}
