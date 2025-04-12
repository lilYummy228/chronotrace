using Input;
using UnityEngine;

namespace PlayerControl
{
    public class Movement : MonoBehaviour
    {
        [SerializeField] private PlayerInputController _input;
        [SerializeField] private float _speed = 3f;

        private void FixedUpdate()
        {
            transform.position += _speed * Time.fixedDeltaTime * _input.MovingDirection;

            if (_input.MovingDirection != Vector3.zero)
                transform.forward = _input.MovingDirection;
        }
    }
}
