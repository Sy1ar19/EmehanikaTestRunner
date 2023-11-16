using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStarter : MonoBehaviour
{
    private TimeHandler _timeHandler;

    private void Awake()
    {
        _timeHandler = GetComponent<TimeHandler>();
    }

    private void Start()
    {
        _timeHandler.Pause();
    }
}
