using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    [SerializeField] private float _speed = 5f;
    [SerializeField] private InputSystem _inputSystem;

    private CharacterController _characterController;

    private void Awake()
    {
        _characterController = GetComponent<CharacterController>();
    }

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        float horizontalInput = _inputSystem.HorizontalInput;

        Vector3 horizontalMovement = transform.right * horizontalInput * _speed * Time.deltaTime;
        _characterController.Move(horizontalMovement);

        Vector3 newPosition = transform.position;
        newPosition.y = 3f;
        transform.position = newPosition;
    }
}
