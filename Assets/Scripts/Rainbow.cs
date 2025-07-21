using System.Collections;
using UnityEngine;

public class Rainbow : MonoBehaviour
{
    [SerializeField] private Renderer _myRenderer;
    private float _hue = 0;

    void Start()
    {
        StartCoroutine(ChangeColor());
    }

    private IEnumerator ChangeColor()
    {
        while (true)
        {
            _hue += Time.deltaTime * 0.2f;
            if (_hue > 1f) _hue = 0f;

            Color newColor = Color.HSVToRGB(_hue, 1f, 1f);
            _myRenderer.material.color = newColor;

            yield return null;
        }
    }
}
