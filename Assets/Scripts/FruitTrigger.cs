using UnityEngine;

public class FruitTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Monkey"))
        {
            Debug.Log("Ôå!");
            gameObject.SetActive(false); 
        }
    }
}
