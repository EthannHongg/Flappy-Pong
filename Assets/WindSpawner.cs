using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WindSpawner : MonoBehaviour
{
    public GameObject columnPrefabV;
    public float minx;
    public float maxx;
    float miny = -6;
    float maxy = -2;
    float timer;
    public float maxTime;
    //public Text scoreText;
    //int score;

    // Start is called before the first frame update
    void Start()
    {
        SpawnWind();
    }

    // Update is called once per frame
    void Update()
    {
        //int score = int.Parse(scoreText.text.ToString());
        timer += Time.deltaTime;
        if (timer >= maxTime)
        {
            SpawnWind();
            timer = 0;
        }
    }

    void SpawnWind()
    {
        float randXPos = Random.Range(minx, maxx);
        float randYPos = Random.Range(miny, maxy);
        GameObject newColumn = Instantiate(columnPrefabV);
        newColumn.transform.position = new Vector2(randXPos, randYPos);
    }
}
