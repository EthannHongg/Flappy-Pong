using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColumnSpawner : MonoBehaviour
{
    public GameObject columnPrefab;
    public float miny, maxy;
    float minx = 5f;
    float maxx = 6.5f;
    float timer;
    public float maxTime;
    public Text scoreText;
    int score;

    // Start is called before the first frame update
    void Start()
    {
        SpawnColumn();
    }

    // Update is called once per frame
    void Update()
    {
        int score = int.Parse(scoreText.text.ToString());
        timer += Time.deltaTime;
        if (timer >= maxTime)
        {
            SpawnColumn();
            timer = 0;
        }
    }

    void SpawnColumn()
    {
        float randYPos = Random.Range(miny, maxy);
        float randXPos = Random.Range(minx, maxx);
        GameObject newColumn = Instantiate(columnPrefab);
        newColumn.transform.position = new Vector2(randXPos, randYPos);
    }
}
