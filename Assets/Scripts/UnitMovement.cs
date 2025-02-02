using UnityEngine;

public class UnitMovement : MonoBehaviour
{
    public float speed = 2f;
    public int health = 10;
    public int attackPower = 2;
    public string enemyTag = "";

    void Update()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }
}
