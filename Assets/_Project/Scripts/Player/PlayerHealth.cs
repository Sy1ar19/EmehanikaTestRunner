using System;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private int _health = 5;

    public event Action HealthChanged;
    public event Action Died;

    public int Health => _health;

    public void TakeDamage()
    {
        if (_health > 0)
        {
            _health -= 1;
            HealthChanged?.Invoke();
        }

        if (_health <= 0)
            Died?.Invoke();
    }

    public void AddHealth()
    {
        _health = Mathf.Clamp(_health + 1, 0, 5);
        HealthChanged?.Invoke();
    }
}
