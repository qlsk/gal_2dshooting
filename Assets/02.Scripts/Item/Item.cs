using UnityEngine;

public class Item : MonoBehaviour
{
    [SerializeField] protected float _startTimer;
    [SerializeField] protected float _moveSpeed;

    private void Start()
    {
    }

    private void Update()
    {
        _startTimer -= Time.deltaTime;
        if (_startTimer <= 0)
        {
            Vector3 dir = Vector3.down;
            transform.position += _moveSpeed * Time.deltaTime * dir;
        }
    }
}