using UnityEngine;

public class Distancemeter : MonoBehaviour
{
    [SerializeField]
    private Transform _target1;

    [SerializeField]
    private Transform _target2;

    [SerializeField]
    TMPro.TextMeshProUGUI _textLabel;

    [SerializeField]
    Transform[] _objectsForEnableOnDistance = new Transform[0];
    
    [SerializeField]
    string _sceneToLoadOnDistance = "Scene2";

    [SerializeField]
    private EventOnDistance[] _eventOnDistances = new EventOnDistance[0];

    private void Awake()
    {
        _eventOnDistances = new EventOnDistance[]
        {
            new ActivateObjectsOnDistance(_objectsForEnableOnDistance, 2),
            new LoadSceneOnDistance(_sceneToLoadOnDistance, 1)
        };
    }

    private void Update()
    {
        float distance = Vector3.Distance(_target1.position, _target2.position);
        _textLabel.text = distance.ToString("f2");

        for (int i = 0; i < _eventOnDistances.Length; i++)
        {
            _eventOnDistances[i].Update(distance);
        }
    }
}
