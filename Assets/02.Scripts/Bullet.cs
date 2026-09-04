using UnityEngine;

public class Bullet : MonoBehaviour
{
    [Header("이동속도")] public float Speed = 5f;
    public int Damage;
    private void Start()
    {
    }

    private void Update()
    {
        // 1. 방향을 구한다.
        Vector2 dir = Vector2.up;

        // 2. 이동하고 싶다. (공식: P = P0 + vt)
        transform.position += Speed * Time.deltaTime * (Vector3)dir;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(this.gameObject);

        if (other.gameObject.CompareTag("Enemy"))
        {
            Enemy enemy = other.gameObject.GetComponent<Enemy>();
            enemy.TakeDamage(Damage);
        }
    }
}