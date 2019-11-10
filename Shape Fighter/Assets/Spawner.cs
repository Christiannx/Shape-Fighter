using UnityEngine;

public class Spawner : MonoBehaviour {
    public Enemy enemy;
    public Sprite enemySquare;
    public Sprite enemyCircle;
    public Sprite enemyTriangle;

    void Start() {
        InvokeRepeating(nameof(Spawn), 0, 0.8f);
    }

    public void Spawn() {
        Enemy instance = Instantiate(enemy, transform.position, Quaternion.identity);
        var i = Random.Range(1, 4);
        switch(i) {
            case 1: instance.shape = Shape.Circle; 
                    instance.GetComponent<SpriteRenderer>().sprite = enemyCircle; break;
            case 2: instance.shape = Shape.Triangle; 
                    instance.GetComponent<SpriteRenderer>().sprite = enemyTriangle; break;
            case 3: instance.shape = Shape.Square; 
                    instance.GetComponent<SpriteRenderer>().sprite = enemySquare; break;
            default: instance.shape = Shape.Circle; 
                    instance.GetComponent<SpriteRenderer>().sprite = enemyCircle; break;
        }
    }
}
