using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarrierMoveDown : MonoBehaviour
{
    public float speed;
    float groundLength;
    BoxCollider2D groundCollider;
    public float downLimit;
    float timer;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        transform.position = new Vector2(transform.position.x
            , transform.position.y - speed * Time.deltaTime);
        if (gameObject.CompareTag("Column"))
        {
            if (transform.position.y <= downLimit)
            {
                Destroy(gameObject);
            }
        }
        if (gameObject.CompareTag("Barrier"))
        {
            if (transform.position.y <= downLimit)
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
