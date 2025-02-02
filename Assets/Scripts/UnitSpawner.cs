using System;
using UnityEngine;

public class UnitSpawner : MonoBehaviour
{
    public GameObject unitPrefab; // 생성할 유닛 프리팹
    public Transform spawnPoint; // 스폰 위치
    public bool isRedTeam; // 팀 여부 (true = Red, false = Blue)

    public void SpawnUnit()
    {
        Debug.Log("SpawnUnit() 실행됨!"); // 디버그 로그

        if (unitPrefab == null || spawnPoint == null)
        {
            Debug.LogError("❌ unitPrefab 또는 spawnPoint가 null입니다!");
            return;
        }

        GameObject unit = Instantiate(unitPrefab, spawnPoint.position, Quaternion.identity);
        Debug.Log("✅ 유닛 생성됨: " + unit.name);

        UnitMovement movement = unit.GetComponent<UnitMovement>();
        if (movement == null)
        {
            Debug.LogError("❌ UnitMovement 스크립트가 Unit 프리팹에 없습니다!");
            return;
        }

        if (isRedTeam)
        {
            movement.speed = 2f;
            movement.enemyTag = "BlueUnit";
            Debug.Log("▶️ Red Team 유닛 생성");
        }
        else
        {
            movement.speed = -2f;
            movement.enemyTag = "RedUnit";
            Debug.Log("🔵 Blue Team 유닛 생성");
        }
    }
}
