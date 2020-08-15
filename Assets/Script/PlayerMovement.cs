using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerMovement : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    Rigidbody2D rb;
    public Vector2 jumpHeight;
    int score;

    public GameObject gameOver;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb.AddForce(jumpHeight, ForceMode2D.Impulse);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("point"))
        {
            score++;
            scoreText.text = score.ToString();
        }

        if (other.gameObject.CompareTag("pipa"))
        {
            if (score > PlayerPrefs.GetInt("HighScore"))
            {
                PlayerPrefs.SetInt("HighScore", score);
            }
            Destroy(gameObject);
            Time.timeScale = 0;
            Debug.Log("HighScore : " + PlayerPrefs.GetInt("HighScore"));
            gameOver.SetActive(true);
        }
    }
}
