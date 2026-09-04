using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    // 생성할 총알 프리팹
    public GameObject BulletPrefab;

    // 총구
    public GameObject LeftFirePosition;
    public GameObject RightFirePosition;

    // 총알 쿨타입
    public float CoolTime = 0.6f;
    public float CoolTimer = 0;

    private void Start()
    {
        CoolTimer = CoolTime;
    }

    private void Update()
    {
        CoolTimer -= Time.deltaTime;

        if (CoolTimer <= 0 && Input.GetButtonDown("Fire1"))
        {
            Fire();
            CoolTimer = CoolTime;
        }
    }

    // 목표: 총알을 만들어서 발사하고 싶다.
    public void Fire()
    {
        // 1. 발사 버튼을 누르면
        // 2. 프리팹으로부터 총알 만들기
        GameObject rightBullet = Instantiate(BulletPrefab);
        GameObject leftBullet = Instantiate(BulletPrefab);

        // 3. 총알 위치를 총구 위치로 바꾸기
        rightBullet.transform.position = RightFirePosition.transform.position;
        leftBullet.transform.position = LeftFirePosition.transform.position;
    }
}