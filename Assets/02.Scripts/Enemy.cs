using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float MoveSpeed = 5f;

    private void Start()
    {
    }

    private void Update()
    {
        // 1. 방향을 구한다.
        Vector3 dir = Vector3.down;

        // 2. 이동한다.
        transform.position += MoveSpeed * Time.deltaTime * dir;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        Destroy(gameObject);

        Destroy(other.gameObject);
    }
}