using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManagerScript : MonoBehaviour
{
    public int score;
    private AudioSource ufoExplode;
    public AudioClip ufoExplosion;

    public TextMeshProUGUI scoreText;

    private void Start()
    {
        ufoExplode= GetComponent<AudioSource>();
    }
    public void IncreaseScore(int amount)
    {
        score += amount;
        UpdateScoreText();
        ufoExplode.PlayOneShot(ufoExplosion, 0.2f);
    }

    public void DecreaseScore(int amount)
    {
        score -= amount;
        UpdateScoreText();
    }

    public void UpdateScoreText()
    {
        scoreText.text = "Score: " + score;
    }
}
