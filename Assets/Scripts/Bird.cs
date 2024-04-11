using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bird : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D rb;
    public GameObject gameOver;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Time.timeScale = 1;
        gameOver.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector2.up * moveSpeed);
        }
    }

    public void ReSetGame()
    {
        SceneManager.LoadScene(1);
    }

    public void ExitGame()
    {
        SceneManager.LoadScene(0);
    }

    public void GameOver()
    {
        Time.timeScale = 0;
        gameOver.SetActive(true);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameOver();
    }
}
