using UnityEngine;

public class BlockSpawner : MonoBehaviour
{
    public GameObject smallBlockPrefab; // 프리팹 참조
    public Transform spawnPoint; // 소환 위치
    public float moveSpeed = 2f; // 이동 속도
    public float maxDistance = 5f; // 최대 이동 거리

    void Update()
    {
        // 마우스 클릭 감지
        if (Input.GetMouseButtonDown(0)) // 마우스 왼쪽 버튼 클릭
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                if (hit.collider.CompareTag("Button")) // 버튼 태그 확인
                {
                    SpawnBlock();
                }
            }
        }
    }

    void SpawnBlock()
    {
        // 블록 생성
        GameObject newBlock = Instantiate(smallBlockPrefab, spawnPoint.position, Quaternion.identity);
        newBlock.GetComponent<SmallBlock>().Initialize(moveSpeed, maxDistance);
    }
}
