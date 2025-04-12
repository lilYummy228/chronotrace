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
            transform.Translate(_input.MovingDirection * _speed * Time.fixedDeltaTime, Space.Self);
        }
    }
}
