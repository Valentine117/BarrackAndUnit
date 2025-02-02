using UnityEngine;

public class SmallBlock : MonoBehaviour
{
    [SerializeField] public float moveSpeed; // 이동 속도
    [SerializeField] public float maxDistance; // 최대 이동 거리
    [SerializeField] public Vector3 startPosition; // 초기 위치

    public void Initialize(float speed, float distance)
    {
        moveSpeed = speed;
        maxDistance = distance;
        startPosition = transform.position;
    }

    void Update()
    {
        // 블록 이동
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);

        // 이동 거리 체크
        if (Vector3.Distance(startPosition, transform.position) >= maxDistance)
        {
            Destroy(gameObject); // 소멸
        }
    }
}
