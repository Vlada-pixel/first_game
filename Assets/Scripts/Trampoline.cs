using UnityEngine;
using System.Collections;

public class Trampoline : MonoBehaviour
{
    [SerializeField] private float jumpForce = 5f;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Monkey"))
        {
            Rigidbody rb = collision.collider.attachedRigidbody;

            if (rb != null)
            {
                rb.linearVelocity = new Vector3(rb.linearVelocity.x, 0f, rb.linearVelocity.z);
                rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);

                Debug.Log("Мавпа стрибнула від батута!");
            }
        }
    }
}
