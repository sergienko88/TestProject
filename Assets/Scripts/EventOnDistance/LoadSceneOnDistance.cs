using System;
using UnityEngine;
using UnityEngine.SceneManagement;

[Serializable]
public class LoadSceneOnDistance: EventOnDistance
{
    [SerializeField]
    private string _sceneName;

    public LoadSceneOnDistance(string sceneName, float borderDistance) : base(borderDistance)
    {
        _sceneName = sceneName;
    }

    public override void Update(float distance)
    {
        if(distance < BorderDistance)
        {
            SceneManager.LoadScene(_sceneName);
        }
    }
}