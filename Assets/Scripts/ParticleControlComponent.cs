using UnityEngine;

public class ParticleControlComponent : MonoBehaviour
{
    [SerializeField]
    private ParticleSystem _particleSystem;

    [SerializeField]
    private Transform _target;


    private void Update()
    {
        if(_target != null)
        {
            _particleSystem.transform.LookAt(_target);
        }
    }
}
