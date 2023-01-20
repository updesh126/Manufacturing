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
    public int index = 0;
    public int sum = 0;

    public static int[] scoreValue = new int[8];
    Text score;
    // Start is called before the first frame update
    void Start()
    {
        //scoreValue[index] = 0;
        score = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "Score:" + scoreValue[index].ToString();
        SumSco();
    }
    public void ADDScore(int Add)
    {
        scoreValue[index] += Add;
        CheckScore();
    }
    public void SubScore(int Sub)
    {
        scoreValue[index] -= Sub;
        CheckScore();
    }
    private void CheckScore()
    {
        if (scoreValue[index] <= 0)
        {
            image.sprite = starSprite0;
        }
        else if (0<= scoreValue[index] && scoreValue[index] <= 20)
        {
            image.sprite = StarSprite1;
        }
        else if (20 <= scoreValue[index] && scoreValue[index] <= 50)
        {
            image.sprite = StarSprite2;
        }
        else
        {
            image.sprite = StarSprite3;
        }

        //score.text = "Score:" + scoreValue[index];
    }
    private void SumSco()
    {
        sum = 0;
        for (int i = 0; i < 8; i++)
        {
            sum += scoreValue[i];
        }
    }
}
