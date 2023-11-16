using TMPro;
using UnityEngine;

public class DeathHandler : MonoBehaviour
{
    [SerializeField] private PlayerHealth _playerHealth;
    [SerializeField] private TimeHandler _timeHandler;
    [SerializeField] private GameObject _deathPanel;
    [SerializeField] private TextMeshProUGUI _textScore;
    [SerializeField] private Score _score;

    private void OnEnable()
    {
        _playerHealth.Died += OnDied;
    }

    private void OnDisable()
    {
        _playerHealth.Died -= OnDied;
    }

    private void OnDied()
    {
        _timeHandler.Pause();
        _deathPanel.SetActive(true);
        _textScore.text = "Ваш результат - " + _score.ScoreCount;
    }
}
