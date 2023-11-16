using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _scoreText;

    private int _scoreCount = 0;
    private float _timer = 0f;
    private float _updateInterval = 1f;

    public int ScoreCount => _scoreCount;

    private void Update()
    {
        _timer += Time.deltaTime;

        if (_timer >= _updateInterval)
        {
            _scoreCount++;

            _scoreText.text = "Очки - " + _scoreCount;

            _timer = 0f;
        }
    }
}
