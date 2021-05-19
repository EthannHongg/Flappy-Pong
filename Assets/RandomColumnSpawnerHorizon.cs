using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomColumnSpawnerHorizon : MonoBehaviour
{
    public GameObject columnPrefab;
    public float miny, maxy;
    public float minx;
    public float maxx;
    float timer;
    public float maxTime;

    // Start is called before the first frame update
    void Start()
    {
        SpawnColumn();
    }

    // Update is called once per frame
    void Update()
    {
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
