using UnityEngine;

public class AllInOneCube : MonoBehaviour
{
    [SerializeField] private float _scalingSpeed;
    [SerializeField] private float _timeToChangeScalingDirection;
    [SerializeField] private float _remainingTimeToChangeScalingDirection;
    [SerializeField] private bool _isGettingBigger;
    [SerializeField] private float _rotatingSpeed;
    [SerializeField] private float _movingSpeed;

    private void Update()
    {
        transform.Translate(transform.forward * _movingSpeed * Time.deltaTime);
        transform.RotateAround(transform.position, transform.up, _rotatingSpeed * Time.deltaTime);
        ChangeScale();
    }

    private void ChangeScale() 
    {

        CheckScalingTime();
        if(_isGettingBigger)
        {
            transform.localScale += new Vector3(_scalingSpeed, _scalingSpeed, _scalingSpeed);
        }
        else
        {
            transform.localScale -= new Vector3(_scalingSpeed, _scalingSpeed, _scalingSpeed);
        }
    }

    private void CheckScalingTime()
    {
        if(_remainingTimeToChangeScalingDirection > 0)
        {
            _remainingTimeToChangeScalingDirection -= Time.deltaTime;
        }
        else
        {
            ChangeScalingDirection();
           _remainingTimeToChangeScalingDirection = 2f;
        }
    }

    private void ChangeScalingDirection()
    {
        _isGettingBigger = !_isGettingBigger;
    }
}
