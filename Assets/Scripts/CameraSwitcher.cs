using Unity.Cinemachine;
using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
    [SerializeField] private CinemachineCamera[] cameras;

    private void Start()
    {
        // Активуємо першу камеру за замовчуванням
        ActivateCamera(0);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
            ActivateCamera(0);
        if (Input.GetKeyDown(KeyCode.Alpha2))
            ActivateCamera(1);
        if (Input.GetKeyDown(KeyCode.Alpha3))
            ActivateCamera(2);
        if (Input.GetKeyDown(KeyCode.Alpha4))
            ActivateCamera(3);
    }

    private void ActivateCamera(int index)
    {
        for (int i = 0; i < cameras.Length; i++)
        {
            if (cameras[i] != null)
                cameras[i].Priority = (i == index) ? 10 : 0;
        }
    }
}
