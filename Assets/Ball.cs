using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Ball : MonoBehaviour
{
    public float health;
    public Score scoreText;
    public GameObject health1;
    public GameObject health2;
    public GameObject health3;
    public GameObject Replay;
    public GameObject mainMenu;
    public GameObject s0;
    public GameObject s1;
    public GameObject s2;
    public GameObject s3;
    public GameObject s4;
    public GameObject s5;
    public GameObject s6;
    public GameObject s7;
    public GameObject s8;
    public GameObject Paddle;
    float timer;
    List<int> mapScore = new List<int>();
    List<int> mapSpawner = new List<int>();
    int current;
    int scoreCount;
    List<int> testMap = new List<int> {5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5};

    // Start is called before the first frame update
    void Start()
    {
        current = 0;
        scoreCount = 0;
        GenerateMap();
        //foreach (int i in mapScore)
        //{
        //    print(i);
        //}
        //foreach (int i in mapSpawner)
        //{
        //    print(i);
        //}

    }

    // Update is called once per frame
    void Update()
    {
        float paddleX;
        paddleX = GameObject.Find("Paddle").transform.position.x;
        transform.position = new Vector2(paddleX, transform.position.y);
        timer += Time.deltaTime;

        if (current == 12)
        {
            Invoke("Last", 5);
        }
        else
        {
            if (scoreCount == mapSpawner[current])
            {
                scoreCount = 0;
                s0.SetActive(false);
                s1.SetActive(false);
                s2.SetActive(false);
                s3.SetActive(false);
                s4.SetActive(false);
                s5.SetActive(false);
                s6.SetActive(false);
                s7.SetActive(false);
                s8.SetActive(false);
                Invoke("ChangeSpawner", 2);
                current += 1;
                print(current);
                print(mapScore[current]);
            }
        }
            
    }

    void Last()
    {
        s8.SetActive(true);
    }

    void ChangeSpawner()
    {
        if (mapScore[current] == 1)
        {
            s1.SetActive(true);
        }
        if (mapScore[current] == 2)
        {
            s2.SetActive(true);
        }
        if (mapScore[current] == 3)
        {
            s3.SetActive(true);
        }
        if (mapScore[current] == 4)
        {
            s4.SetActive(true);
        }
        if (mapScore[current] == 5)
        {
            s5.SetActive(true);
        }
        if (mapScore[current] == 6)
        {
            s6.SetActive(true);
        }
        if (mapScore[current] == 7)
        {
            s7.SetActive(true);
        }
        if (mapScore[current] == 8)
        {
            s8.SetActive(true);
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Barrier")
        {
            if (health > 1)
            {
                LoseHealth();
            }
            else
            {
                LoseHealth();
                GameOver();
            }
        }
        
        if (col.gameObject.tag == "Lava")
        {
            GameOver();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Column"))
        {
            scoreText.ScoreUp();
            scoreCount += 1;
        }
        if (collision.CompareTag("PlusPoint"))
        {
            
            scoreText.ScoreUp();
            scoreText.ScoreUp();
            scoreCount += 2;
        }
    }

    void GameOver()
    {
        //GameStateManager.GameState = GameState.Dead;
        //DeathGUI.SetActive(true);
        //GetComponent<AudioSource>().PlayOneShot(DeathAudioClip);
        Time.timeScale = 0;
        Replay.SetActive(true);
        mainMenu.SetActive(true);
    }

    void LoseHealth()
    {
        //audio
        //animation or screenshake
        if (health > 0)
        {
            health -= 1;
            if (health == 2)
            {
                health3.SetActive(false);
            }
            if (health == 1)
            {
                health2.SetActive(false);
            }
            if (health == 0)
            {
                health1.SetActive(false);
            }
        }
    }

    public void ReplayGame()
    {
        SceneManager.LoadScene("Game");
        Time.timeScale = 1;
        Replay.SetActive(false);
        health1.SetActive(true);
        health2.SetActive(true);
        health3.SetActive(true);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Start");
    }

    public void Special()
    {
        SceneManager.LoadScene("BlockChain");
    }

    void GenerateMap()
    {
        mapSpawner.Add(Random.Range(15, 20));

        int second1;
        second1 = Random.Range(1, 4);
        mapScore.Add(second1);
        if (second1 == 1)
        {
            mapSpawner.Add(Random.Range(10, 20));
        }
        if (second1 == 2)
        {
            mapSpawner.Add(Random.Range(25, 40));
        }
        if (second1 == 3)
        {
            mapSpawner.Add(Random.Range(10, 20));
        }

        int second2;
        second2 = Random.Range(1, 4);
        mapScore.Add(second2);
        if (second2 == 1)
        {
            mapSpawner.Add(Random.Range(10, 20));
        }
        if (second2 == 2)
        {
            mapSpawner.Add(Random.Range(25, 40));
        }
        if (second2 == 3)
        {
            mapSpawner.Add(Random.Range(10, 20));
        }

        int second3;
        second3 = Random.Range(1, 4);
        mapScore.Add(second3);
        if (second3 == 1)
        {
            mapSpawner.Add(Random.Range(10, 20));
        }
        if (second3 == 2)
        {
            mapSpawner.Add(Random.Range(25, 40));
        }
        if (second3 == 3)
        {
            mapSpawner.Add(Random.Range(10, 20));
        }

        int second4;
        second4 = Random.Range(1, 4);
        mapScore.Add(second4);
        if (second4 == 1)
        {
            mapSpawner.Add(Random.Range(10, 20));
        }
        if (second4 == 2)
        {
            mapSpawner.Add(Random.Range(25, 40));
        }
        if (second4 == 3)
        {
            mapSpawner.Add(Random.Range(10, 20));
        }

        int third1;
        third1 = Random.Range(3, 6);
        mapScore.Add(third1);
        if (third1 == 3)
        {
            mapSpawner.Add(Random.Range(10, 20));
        }
        if (third1 == 4)
        {
            mapSpawner.Add(Random.Range(10, 20));
        }
        if (third1 == 5)
        {
            mapSpawner.Add(Random.Range(30, 45));
        }

        int third2;
        third2 = Random.Range(3, 6);
        mapScore.Add(third2);
        if (third2 == 3)
        {
            mapSpawner.Add(Random.Range(10, 20));
        }
        if (third2 == 4)
        {
            mapSpawner.Add(Random.Range(10, 20));
        }
        if (third2 == 5)
        {
            mapSpawner.Add(Random.Range(30, 45));
        }

        int third3;
        third3 = Random.Range(3, 6);
        mapScore.Add(third3);
        if (third3 == 3)
        {
            mapSpawner.Add(Random.Range(10, 20));
        }
        if (third3 == 4)
        {
            mapSpawner.Add(Random.Range(10, 20));
        }
        if (third3 == 5)
        {
            mapSpawner.Add(Random.Range(30, 45));
        }

        int third4;
        third4 = Random.Range(3, 6);
        mapScore.Add(third4);
        if (third4 == 3)
        {
            mapSpawner.Add(Random.Range(10, 20));
        }
        if (third4 == 4)
        {
            mapSpawner.Add(Random.Range(10, 20));
        }
        if (third4 == 5)
        {
            mapSpawner.Add(Random.Range(30, 45));
        }

        int forth1;
        forth1 = Random.Range(5, 8);
        mapScore.Add(forth1);
        if (forth1 == 5)
        {
            mapSpawner.Add(Random.Range(30, 45));
        }
        if (forth1 == 6)
        {
            mapSpawner.Add(Random.Range(20, 30));
        }
        if (forth1 == 7)
        {
            mapSpawner.Add(Random.Range(10, 20));
        }

        int forth2;
        forth2 = Random.Range(5, 8);
        mapScore.Add(forth2);
        if (forth2 == 5)
        {
            mapSpawner.Add(Random.Range(30, 45));
        }
        if (forth2 == 6)
        {
            mapSpawner.Add(Random.Range(20, 30));
        }
        if (forth2 == 7)
        {
            mapSpawner.Add(Random.Range(10, 20));
        }

        int forth3;
        forth3 = Random.Range(5, 8);
        mapScore.Add(forth3);
        if (forth3 == 5)
        {
            mapSpawner.Add(Random.Range(30, 45));
        }
        if (forth3 == 6)
        {
            mapSpawner.Add(Random.Range(20, 30));
        }
        if (forth3 == 7)
        {
            mapSpawner.Add(Random.Range(10, 20));
        }

        int forth4;
        forth4 = Random.Range(5, 8);
        mapScore.Add(forth4);
        if (forth4 == 5)
        {
            mapSpawner.Add(Random.Range(30, 45));
        }
        if (forth4 == 6)
        {
            mapSpawner.Add(Random.Range(20, 30));
        }
        if (forth4 == 7)
        {
            mapSpawner.Add(Random.Range(10, 20));
        }

    }
}
