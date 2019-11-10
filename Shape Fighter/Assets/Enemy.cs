using UnityEngine;

public class Enemy : MonoBehaviour {
    public Shape shape;
    public float moveSpeed = 10f;
    public new Rigidbody2D rigidbody;

    void Update() {
        rigidbody.MovePosition(rigidbody.position + new Vector2(-moveSpeed, 0) * Time.deltaTime);
    }
}
