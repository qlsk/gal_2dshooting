using UnityEngine;

public class Bullet : MonoBehaviour
{
    [Header("이동속도")] public float Speed = 5f;

    public int Damage;

    private bool _isHit = false;

    private void Update()
    {
        transform.position += Speed * Time.deltaTime * Vector3.up;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (_isHit)
            return;

        Enemy enemy = other.GetComponentInParent<Enemy>();

        if (enemy == null)
            return;

        _isHit = true;

        enemy.TakeDamage(Damage);

        Destroy(gameObject);
    }
}