using UnityEngine;

public class Bootstrap : MonoBehaviour 
{
    [Header("Player")]
    [SerializeField] private PlayerConfig _playerConfig;
    [SerializeField] private Player _player;
    [SerializeField] private Transform _playerBody;
    [SerializeField] private Transform _playerCamera;

    [Header("Builder")]
    [SerializeField] private BuilderConfig _builderConfig;
    [SerializeField] private Builder _builder;
    [SerializeField] private Transform _builderRayCastPoint;

    private void Awake()
    {
        IInputSystem inputSystem = new PCInput();

        InitializePlayer(inputSystem);
        InitializeBuilder(inputSystem);
    }

    private void InitializePlayer(IInputSystem inputSystem)
    {
        FirstPersonCamera firstPersonCamera = new FirstPersonCamera(_playerCamera, _playerBody, _playerConfig, inputSystem);
        PlayerLooking playerLooking = new PlayerLooking(firstPersonCamera);
        SetCameraRotator setCameraRotator = new SetCameraRotator(playerLooking, firstPersonCamera);

        PlayerMovement playerMovement = new PlayerMovement(_player.transform, inputSystem, _playerConfig);

        _player.Inirialize(playerLooking, playerMovement);
    }
    
    private void InitializeBuilder(IInputSystem inputSystem)
    {
        _builder.Initialize(inputSystem, _builderConfig, _builderRayCastPoint);
    }
}
