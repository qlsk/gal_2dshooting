using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float MoveSpeed = 5f;
    [SerializeField] private float _health = 10f;

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

    public void TakeDamage(int damage)
    {
        // 충돌 시 체력 감소
        _health -= damage;
        // 체력이 0 이하라면
        if (_health <= 0)
        {
            // 제거
            Destroy(gameObject);
        }
    }
}