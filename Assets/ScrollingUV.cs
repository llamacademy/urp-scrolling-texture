using UnityEngine;

[RequireComponent(typeof(Renderer))]
public class ScrollingUV : MonoBehaviour
{
    [SerializeField]
    private Vector2 ScrollSpeed = Vector2.one;
    private Material ActiveMaterial;

    private void Awake()
    {
        ActiveMaterial = GetComponent<Renderer>().material;
    }

    private void Update()
    {
        ActiveMaterial.mainTextureOffset += ScrollSpeed / Time.deltaTime;
    }
}
