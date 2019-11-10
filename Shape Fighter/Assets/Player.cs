using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {
    public Bullet bullet;
    public Sprite bulletSquare;
    public Sprite bulletCircle;
    public Sprite bulletTriangle;
    public float fireRate = 0.5f;

    bool canSpawn = true;

    public void EnableSpawn() => canSpawn = true;

    void Update() {

        if (canSpawn) {
            if (Input.GetKeyDown("a")) {
                var bulletInstance = Instantiate(bullet, transform.position, Quaternion.identity);
                bulletInstance.GetComponent<SpriteRenderer>().sprite = bulletSquare;
                bulletInstance.shape = Shape.Square;

                canSpawn = false;
                Invoke(nameof(EnableSpawn), fireRate);
            } else if (Input.GetKeyDown("s")) {
                var bulletInstance = Instantiate(bullet, transform.position, Quaternion.identity);
                bulletInstance.GetComponent<SpriteRenderer>().sprite = bulletCircle;
                bullet.shape = Shape.Circle;

                canSpawn = false;
                Invoke(nameof(EnableSpawn), fireRate);
            } else if (Input.GetKeyDown("d")) {
                var bulletInstance = Instantiate(bullet, transform.position, Quaternion.identity);
                bulletInstance.GetComponent<SpriteRenderer>().sprite = bulletTriangle;
                bulletInstance.shape = Shape.Triangle;

                canSpawn = false;
                Invoke(nameof(EnableSpawn), fireRate);
            }
        }
    }

    void OnTriggerEnter2D(Collider2D c) {
        if (c.GetComponent<Enemy>()) {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
