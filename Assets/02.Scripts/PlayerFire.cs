using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    // 생성할 총알 프리팹
    public GameObject BulletPrefab;

    // 총구
    public GameObject LeftFirePosition;
    public GameObject RightFirePosition;

    private void Start()
    {
    }

    private void Update()
    {
        // 목표: 총알을 만들어서 발사하고 싶다.

        // 1. 발사 버튼을 누르면
        if (Input.GetButtonDown("Fire1"))
        {
            // 2. 프리팹으로부터 총알 만들기
            GameObject rightBullet = Instantiate(BulletPrefab);
            GameObject leftBullet = Instantiate(BulletPrefab);

            // 3. 총알 위치를 총구 위치로 바꾸기
            rightBullet.transform.position = RightFirePosition.transform.position;
            leftBullet.transform.position = LeftFirePosition.transform.position;
        }
    }
}