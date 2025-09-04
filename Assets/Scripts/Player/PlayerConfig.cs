using UnityEngine;

[CreateAssetMenu(fileName = "PlayerConfig", menuName = "Scriptable Objects/PlayerConfig")]
public class PlayerConfig : ScriptableObject
{
    [Header("Rotation and movement")]
    [SerializeField] public float RotationSpeed;
    [SerializeField] public float MoveSpeed;
}
