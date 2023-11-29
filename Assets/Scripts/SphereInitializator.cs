
using UnityEngine;

public class SphereInitializator : MonoBehaviour
{
    [SerializeField]
    private MeshRenderer[] _sphereMeshRenderers = new MeshRenderer[0];

    [SerializeField]
    private Texture[] _atlasTextures = new Texture[0];
  
    private void Awake()
    {
        _sphereMeshRenderers = GetComponentsInChildren<MeshRenderer>();

        for (int i = 0; i < _sphereMeshRenderers.Length; i++)
        {
            _sphereMeshRenderers[i].SetPropertyBlock(new MaterialPropertyBlock());
            _sphereMeshRenderers[i].material.mainTexture = _atlasTextures[i];
        }
    }
}
