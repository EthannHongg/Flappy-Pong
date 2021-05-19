using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovingBarrierMoveLeft : MonoBehaviour
{
    public float speed;
    float groundLength;
    BoxCollider2D groundCollider;
    public float leftLimit;
    float timer;
    float randomTime;
    public float maxTime;
    // Start is called before the first frame update
    void Start()
    {
        int x = Random.Range(1, 3);
        if (x == 1)
        {
            speed = -speed;
        }
        //print(speed);
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        //print(timer);
        if(timer >= maxTime)
        {
            speed = -speed;
            timer = 0;
        }
        transform.position = new Vector2(transform.position.x - Mathf.Abs(speed) * Time.deltaTime, transform.position.y - speed / 2 * Time.deltaTime);
        if (gameObject.CompareTag("Column"))
        {
            if (transform.position.x <= leftLimit)
            {
                Destroy(gameObject);
                
            }
        }
    }
}
