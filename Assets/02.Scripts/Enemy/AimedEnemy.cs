using UnityEngine;

public class AimedEnemy : Enemy
{
    private GameObject _player;
    private Vector2 _direction;

    private void Start()
    {
        _player = GameObject.FindWithTag("Player");

        _direction = _player.transform.position - transform.position;
        _direction.Normalize();
    }

    private void Update()
    {
        transform.Translate(_moveSpeed * Time.deltaTime * _direction);
    }
}