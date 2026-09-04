using UnityEngine;

public class HomingEnemy : Enemy
{
    private GameObject _player;
    private Vector2 _direction;

    private void Start()
    {
        _player = GameObject.FindGameObjectWithTag("Player");
    }

    private void Update()
    {
        _direction = _player.transform.position - transform.position;
        _direction.Normalize();
        transform.Translate(_moveSpeed * Time.deltaTime * _direction);
    }
}