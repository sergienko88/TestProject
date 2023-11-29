using System;
using UnityEngine;

[Serializable]
public class ActivateObjectsOnDistance: EventOnDistance
{
    [SerializeField]
    private Transform[] _objects;


    public ActivateObjectsOnDistance(Transform[] objects, float borderDistance) : base(borderDistance)
    {
        _objects = objects;
    }

    public override void Update(float distance)
    {
        Transform tObj;
        bool state = false;

        for (int i = 0; i < _objects.Length; i++)
        {
            tObj = _objects[i];
            state = distance < BorderDistance;

            if (tObj.gameObject.activeSelf != state)
            {
                tObj.gameObject.SetActive(state);
            }
        }

    }
}
