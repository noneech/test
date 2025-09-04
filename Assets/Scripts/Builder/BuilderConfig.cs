using UnityEngine;

[CreateAssetMenu(fileName = "BuilderConfig", menuName = "Scriptable Objects/BuilderConfig")]
public class BuilderConfig : ScriptableObject
{
    [Header("Building")]
    [SerializeField] public float BuildDistance;
}
