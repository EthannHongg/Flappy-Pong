using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TunnelSpawner : MonoBehaviour
{
    public GameObject columnPrefab;
    float timer;
    static float midy;
    static float miny;
    static float maxy;
    public float maxTime;
    //public Text scoreText;
    //int score;

    // Start is called before the first frame update
    void Start()
    {
        midy = Random.Range(-1.8f, 1.8f);
        miny = midy - 1.8f;
        maxy = midy + 1.8f;
        SpawnTunnel();
        //print(midy);
    }

    // Update is called once per frame
    void Update()
    {
        //int score = int.Parse(scoreText.text.ToString());
        timer += Time.deltaTime;
        if (timer >= maxTime)
        {
            SpawnTunnel();
            timer = 0;
        }
    }

    void SpawnTunnel()
    {
        //print(midy);
        float randYPos = Random.Range(miny, maxy);
        while (randYPos > 2.5)
        {
            randYPos = Random.Range(miny, maxy);
        }
        while (randYPos < -2.5)
        {
            randYPos = Random.Range(miny, maxy);
        }
        GameObject newColumn = Instantiate(columnPrefab);
        newColumn.transform.position = new Vector2(transform.position.x, randYPos);
        midy = randYPos;
        miny = midy - 1.8f;
        maxy = midy + 1.8f;
    }
}
