using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lava : MonoBehaviour
{
    public float speed;
    float maxHeight;
    bool peaked;
    public GameObject rockFall;
    // Start is called before the first frame update
    void Start()
    {
        maxHeight = Random.Range(-5f, -3f);
        rockFall.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(transform.position.x, transform.position.y + speed * Time.deltaTime);
        if (transform.position.y >= maxHeight)
        {
            speed = -1;
        }
        if (transform.position.y <= -11)
        {
            rockFall.SetActive(false);
            gameObject.SetActive(false);
        }
    }
}
