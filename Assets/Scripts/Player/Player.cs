using UnityEngine;

public class Player : MonoBehaviour
{
    private PlayerLooking _playerLooking;
    private PlayerMovement _playerMovement;
    

    public void Inirialize(PlayerLooking playerLooking, PlayerMovement playerMovement)
    {
        _playerLooking = playerLooking;
        _playerMovement = playerMovement;
    }

    private void Update()
    {
        _playerLooking.RotateCamera();
        _playerMovement.Move();
    }
}
