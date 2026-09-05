using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private int _health = 10;
    [SerializeField] protected float _moveSpeed;
    [SerializeField] protected float _damage;

    [SerializeField] Item _itemMoveSpeedUp;
    [SerializeField] Item _itemHealthUp;
    [SerializeField] Item _itemFireSpeedUp;

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
            // 30퍼 확률로 아이템 생성
            int itemSpawnRandom = Random.Range(0, 100);
            if (itemSpawnRandom <= 30)
            {
                int whichItemSpawn = Random.Range(0, 4);

                // 아이템 3개 중 하나 스폰
                switch (whichItemSpawn)
                {
                    case 0:
                        Instantiate(_itemFireSpeedUp);
                        _itemFireSpeedUp.transform.position = transform.position; 
                        break;
                    case 1:
                        Instantiate(_itemHealthUp);
                        _itemHealthUp.transform.position = transform.position;
                        break;
                    case 2:
                        Instantiate(_itemMoveSpeedUp);
                        _itemMoveSpeedUp.transform.position = transform.position;
                        break;
                }
            }
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