using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarrierMoveLeft : MonoBehaviour
{
    public float speed;
    float groundLength;
    BoxCollider2D groundCollider;
    public float leftLimit;
    float timer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        transform.position = new Vector2(
            transform.position.x - speed * Time.deltaTime, transform.position.y);
        if (gameObject.CompareTag("Column"))
        {
            if (transform.position.x <= leftLimit)
            {
                Destroy(gameObject);
            }
        }
        if (gameObject.CompareTag("WindArea"))
        {
            if (transform.position.x <= leftLimit)
            {
                Destroy(gameObject);
            }
        }
        if (gameObject.CompareTag("Barrier"))
        {
            if (transform.position.y <= leftLimit)
            {
                Destroy(gameObject);
            }
        }
        if (gameObject.CompareTag("Block"))
        {
            if (timer >= 7)
            {
                Destroy(gameObject);
            }
        }
    }
}
