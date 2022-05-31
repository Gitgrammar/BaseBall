using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AddScore : MonoBehaviour
{
    public static int score = 0;
    public Text scoreText;
    private int highScore = 0;
    public Text highScoreText;
    private string key = "HIGH SCORE";

    void Start()
    {
        score = 0;
        scoreText.text = "0";
        highScore = PlayerPrefs.GetInt(key,0);
        highScoreText.text = "" + highScore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (score > highScore)
        {
            highScore = score;
            PlayerPrefs.SetInt(key, highScore);
            highScoreText.text = "HighScore" + highScore.ToString();
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            score += 100;
            scoreText.text = "" + score.ToString();
        }
    }
}
