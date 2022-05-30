using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;

public class AddScore : MonoBehaviour
{
    private int score = 0;
    public Text scoreText;
    private int highScore = 0;
    public Text highScoreText;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        scoreText.text = "0";
        highScore = PlayerPrefs.GetInt("HighScore");
        highScoreText.text = "" + highScore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
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
