using UnityEngine;

public class Water : MonoBehaviour, ISpawnable
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<PlayerHealth>(out PlayerHealth playerHealth))
        {
            playerHealth.TakeDamage();
        }
    }
}
