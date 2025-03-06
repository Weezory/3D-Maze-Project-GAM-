using UnityEngine;

public class PlayerCollection : MonoBehaviour
{
    // Add a Scoring System here (HW)
    private void OnTriggerEnter(Collider other)
    {
        // Only destroy if collectable
        if (other.CompareTag("Collectable"))
        {
            Destroy(other.gameObject);
        }
    }
}
