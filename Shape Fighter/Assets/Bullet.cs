using UnityEngine;
using UnityEngine.SceneManagement;

public class Bullet : MonoBehaviour {
    public Shape shape;
    public Rigidbody2D rb;
    public float moveSpeed;

    void Update() {
        rb.MovePosition(rb.position + new Vector2(moveSpeed, 0) * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D c) {
        if (c.GetComponent<Enemy>()) {
            if(c.GetComponent<Enemy>().shape == shape) {
                Destroy(c.gameObject);
                Destroy(gameObject);
            } else {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
    }
}

public enum Shape {
    Circle, Square, Triangle
}