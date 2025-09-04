using Unity.Android.Gradle;
using UnityEditor.PackageManager;
using UnityEngine;

public class Builder : MonoBehaviour
{
    [SerializeField] private Block _block;
    [SerializeField] private BuilderPreview _builderPreview;

    private IInputSystem _inputSystem;
    
    private Transform _rayCastPossition;
    private RaycastHit _hitInfo;
    private float _buildDistance;

    public Vector3 BuildPossition => _hitInfo.transform.position + _hitInfo.normal;

    public void Initialize(IInputSystem inputSystem, BuilderConfig builderConfig, Transform rayCastPosition)
    {
        _buildDistance = builderConfig.BuildDistance;
        _inputSystem = inputSystem;
        _rayCastPossition = rayCastPosition;
    }

    private bool CreateRayCast(out RaycastHit hitInfo)
    {
        return Physics.Raycast(_rayCastPossition.position, _rayCastPossition.forward, out hitInfo, _buildDistance);
    }

    private void Build()
    {
        Vector3 buildPossition = BuildPossition;

        Instantiate(_block, BuildPossition, Quaternion.identity);
    }

    private void Update()
    {
        if (_hitInfo.transform == null) return;
        if (_hitInfo.transform.GetComponent<Block>() == null) return;

        if(_inputSystem.IsClick()) Build(); 

    }

    private void FixedUpdate()
    {
        if (CreateRayCast(out _hitInfo) && _hitInfo.transform.GetComponent<Block>())
        {
            if(_builderPreview.IsActive == false)
            {
                _builderPreview.Enable();
            }

            _builderPreview.SetPosition(BuildPossition);
        }
        else
        {
            _builderPreview.Disable();
        }
    }
}
