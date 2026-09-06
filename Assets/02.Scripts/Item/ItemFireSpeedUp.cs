using UnityEngine;

public class ItemFireSpeedUp : Item
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
            PlayerFire[] playerFire = other.gameObject.GetComponents<PlayerFire>();
            foreach (PlayerFire pf in playerFire)
            {
                pf.FireSpeedUp();
            }
            Destroy(gameObject);
        }
    }
}