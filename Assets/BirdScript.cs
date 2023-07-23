using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public new Rigidbody2D rigidbody2D;
    public float flatStrenght;
    public LogicScript logic;
    public bool birdIsAlive = true;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true && birdIsAlive) {
            rigidbody2D.velocity = Vector2.up * flatStrenght;
        }
        if (transform.position.y < -11 || transform.position.y > 11)
        {
            gameOverLogic();
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        gameOverLogic();
    }

    public void gameOverLogic()
    {
        logic.gameOver();
        birdIsAlive = false;
    }
}
