using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShuttingBarrier : MonoBehaviour
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
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        //print(timer);
        if (timer >= maxTime)
        {
            speed = -speed;
            timer = 0;
        }
        transform.position = new Vector2(transform.position.x, transform.position.y - speed / 2 * Time.deltaTime);
        if (gameObject.CompareTag("Barrier"))
        {
            if (transform.position.x <= leftLimit)
            {
                Destroy(gameObject);
            }
        }
    }
}
