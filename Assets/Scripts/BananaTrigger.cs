using UnityEngine;
using System.Collections;

public class BananaTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Monkey"))
        {
            Debug.Log("Ням-ням!");
            gameObject.SetActive(false);
        }
    }
}
