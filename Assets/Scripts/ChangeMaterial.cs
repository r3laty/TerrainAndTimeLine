using UnityEngine;

public class ChangeMaterial : MonoBehaviour
{
    [SerializeField] private Material material;
    private MeshRenderer _renderer;
    private void Awake()
    {
        _renderer = GetComponent<MeshRenderer>();
    }
    public void OnChange()
    {
        _renderer.material = material;
    }
}
