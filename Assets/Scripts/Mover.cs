using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private bool _isMovingForward;
    [SerializeField] private float _timeToChangeDirection;
    [SerializeField] private float _remainingTimeToChangeDirection;

    private void Update()
    {
       if(_remainingTimeToChangeDirection > 0)
       {
           _remainingTimeToChangeDirection -= Time.deltaTime;
       }
       else 
       {
           _speed = -_speed;
           _remainingTimeToChangeDirection = _timeToChangeDirection;
       }

        transform.Translate(transform.forward * _speed * Time.deltaTime);
    }
}
