using System;
using UnityEngine;

[Serializable]
public class EventOnDistance
{
    [SerializeField]
    protected float BorderDistance;

    public EventOnDistance(float borderDistance)
    {
        BorderDistance = borderDistance;
    }

    public virtual void Update(float distance)
    {

    }
}
