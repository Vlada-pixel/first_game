using UnityEngine;
using System.Collections;

public class NewMonoBehaviourScript : MonoBehaviour
{
    [SerializeField] private MeshRenderer _myMeshRender;

    void Start()
    {
        //_myMeshRender.sharedMaterial.SetColor("_BaseColor", new Color(255/255f, 0, 255/255f));
        //_myMeshRender.sharedMaterial.SetFloat("_BumpScale", 2);
        StartCoroutine(ChangeColor());

        IEnumerator ChangeColor()
        {
            while (true)
            {
                _myMeshRender.sharedMaterial.SetColor("_BaseColor", new Color(1f, 0f, 0f)); // червоний
                yield return new WaitForSeconds(1f);

                _myMeshRender.sharedMaterial.SetColor("_BaseColor", new Color(0f, 0f, 1f)); // синій
                yield return new WaitForSeconds(1f);
            }
        }
    }

}
