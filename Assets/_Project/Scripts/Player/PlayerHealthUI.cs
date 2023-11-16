using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthUI : MonoBehaviour
{
    [SerializeField] private PlayerHealth _health;
    [SerializeField] private Sprite _activeSprite;
    [SerializeField] private Sprite _nonActiveSprite;

    private Image[] _lives;

    private void Awake()
    {
        _lives = GetComponentsInChildren<Image>(includeInactive: false);
    }

    private void OnEnable()
    {
        _health.HealthChanged += OnHealthChanged;
    }

    private void OnDisable()
    {
        _health.HealthChanged -= OnHealthChanged;
    }

    private void OnHealthChanged()
    {
        int currentHealth = _health.Health;

        for (int i = 0; i < _lives.Length; i++)
        {
            _lives[i].sprite = (i < currentHealth) ? _activeSprite : _nonActiveSprite;
        }
    }
}