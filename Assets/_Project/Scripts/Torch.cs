using UnityEngine;

public class Torch : MonoBehaviour, ISpawnable
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<PlayerHealth>(out PlayerHealth playerHealth))
        {
            playerHealth.AddHealth();

            Destroy(gameObject);
        }
    }
}
