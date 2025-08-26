using UnityEngine;

public class Scaler : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Vector3 _maximumScale;
    [SerializeField] private Vector3 _minimumScale;
    [SerializeField] private bool _isGettingBigger;
    [SerializeField] private float _timeToCheckScale;
    [SerializeField] private float _remainingTimeToCheckScale;

    private void Start()
    {
        _minimumScale = transform.localScale;
    }

    private void Update()
    {
        if(_remainingTimeToCheckScale > 0)
        {
            _remainingTimeToCheckScale -= Time.deltaTime;
        }
        else 
        {
            CheckScale();
            _remainingTimeToCheckScale = _timeToCheckScale;
        }

        if(_isGettingBigger)
        {
            transform.localScale += new Vector3(_speed, _speed, _speed);
        }
        else 
        {
            transform.localScale -= new Vector3(_speed, _speed, _speed);
        }
    }

    private void CheckScale()
    {
        if(transform.localScale.magnitude <= _maximumScale.magnitude && transform.localScale.magnitude >= _minimumScale.magnitude)
        {
            _isGettingBigger = true;
        }
        else 
        {
            _isGettingBigger = false;
        }
    }
}
