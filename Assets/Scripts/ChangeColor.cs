using UnityEngine;
using System.Collections;

public class NewMonoBehaviourScript : MonoBehaviour
{
    [SerializeField] private MeshRenderer _myMeshRender;
    public float duration = 5f;

    private Color colorA = Color.red;
    private Color colorB = Color.blue;
    private Color currentTarget;
    private float t = 0f;

    void Start()
    {
        currentTarget = colorB;
    }
    void Update()
    {
        t += Time.deltaTime / duration;
        _myMeshRender.sharedMaterial.SetColor("_BaseColor", Color.Lerp(_myMeshRender.sharedMaterial.GetColor("_BaseColor"), currentTarget, t));

        if (t >= 1f)
        {
           currentTarget = (currentTarget == colorA) ? colorB : colorA;
           t = 0f;
        }
    }

}
