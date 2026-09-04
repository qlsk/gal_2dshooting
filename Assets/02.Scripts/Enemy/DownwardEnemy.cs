using UnityEngine;

public class DownwardEnemy : Enemy
{
    private void Start()
    {
    }

    private void Update()
    {
        Vector3 dir = Vector3.down;

        transform.position += _moveSpeed * Time.deltaTime * dir;
    }
}