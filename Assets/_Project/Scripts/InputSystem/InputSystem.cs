using UnityEngine;

public class InputSystem : MonoBehaviour
{
    private const string HorizontalAxis = "Horizontal";

    public float HorizontalInput { get; private set; }

    private void Update()
    {
        HorizontalInput = Input.GetAxis(HorizontalAxis);

        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            float middle = Screen.width / 2f;

            if (touch.position.x < middle)
                HorizontalInput = -1f;
            else if (touch.position.x > middle)
                HorizontalInput = 1f;
        }
    }
}
