using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreScript : MonoBehaviour
{
    public Image image;
    public Sprite starSprite0;
    public Sprite StarSprite1;
    public Sprite StarSprite2;
    public Sprite StarSprite3;


    public static int scoreValue = 0;
    Text score;
    // Start is called before the first frame update
    void Start()
    {
        score = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "Score:" + scoreValue;
    }
    public void ADDScore()
    {
        scoreValue += 10;
        CheckScore();
    }
    public void SubScore()
    {
        scoreValue -= 10;
        CheckScore();
    }
    private void CheckScore()
    {
        if (scoreValue <= 0)
        {
            image.sprite = starSprite0;
        }
        else if (0<=scoreValue && scoreValue <= 20)
        {
            image.sprite = StarSprite1;
        }
        else if (20 <= scoreValue && scoreValue <= 50)
        {
            image.sprite = StarSprite2;
        }
        else
        {
            image.sprite = StarSprite3;
        }
    }
}
