using UnityEngine;

public class ItemHealthUp : Item
{
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

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Player player = other.gameObject.GetComponent<Player>();
            player.HealthUp();
            Destroy(gameObject);
        }
    }
}