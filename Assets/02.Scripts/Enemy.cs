using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private int _health = 10;
    [SerializeField] private float _moveSpeed;
    [SerializeField] private float _damage;

    private void Start()
    {
    }

    private void Update()
    {
        // 1. 방향을 구한다.
        Vector3 dir = Vector3.down;

        // 2. 이동한다.
        transform.position += _moveSpeed * Time.deltaTime * dir;
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

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (!other.gameObject.CompareTag("Player")) return;
        Player player = other.gameObject.GetComponent<Player>();
        player.TakeDamage(1);
    }
}