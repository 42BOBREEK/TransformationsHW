using UnityEngine;

public class Sphere : MonoBehaviour
{
    [SerializeField] private bool _moveToTarget;
    [SerializeField] private float _speed;
    [SerializeField] private Vector3 _firstPosition;
    [SerializeField] private Transform _target;

    private void Start() 
    {
        _firstPosition = transform.position;
    }

    private void Update()
    {
        if(_moveToTarget == true) 
        {
             transform.position = Vector3.MoveTowards(transform.position, _target.position,  _speed * Time.deltaTime);    
        }
        else 
        {
             transform.position = Vector3.MoveTowards(transform.position, _firstPosition,  _speed * Time.deltaTime);    
        }

        CheckPosition();
    }

    private void ChangeDirection() 
    {
        _moveToTarget = !_moveToTarget;
    }

    private void CheckPosition()
    {
        if(transform.position == _target.position || transform.position == _firstPosition)
        {
            ChangeDirection();
        }
    }
}
