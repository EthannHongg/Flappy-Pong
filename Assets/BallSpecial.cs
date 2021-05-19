using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BallSpecial : MonoBehaviour
{
    public float health;
    public GameObject Replay;
    public GameObject health1;
    public GameObject health2;
    public GameObject health3;
    public GameObject mainMenu;
    public GameObject Paddle;
    public Score scoreText;
    float timer;
    public float maxSpeed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        float paddleX;
        paddleX = GameObject.Find("Paddle").transform.position.x;
        transform.position = new Vector2(paddleX, transform.position.y);
        if (timer >= 2)
        {
            scoreText.ScoreUp();
            timer = 0;
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        
        if (col.gameObject.tag == "Block")
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
        SceneManager.LoadScene("BlockChain");
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
}
