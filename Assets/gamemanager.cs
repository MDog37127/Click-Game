using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gamemanager : MonoBehaviour
{
    public Text high;
    public Text score;
    float scorevalue;
    int highscore;
    // Start is called before the first frame update
    void Start()
    {
        scorevalue = 0;
    }

    // Update is called once per frame
    void Update()
    {
        scorevalue += Time.deltaTime * 5;
        highscore = (int)scorevalue;
        score.text = highscore.ToString();

        if (PlayerPrefs.GetInt("Score") <= highscore)
        {
            PlayerPrefs.SetInt("Score", highscore);
        }
    }
    public void highscorestuff()
    {
        high.text = PlayerPrefs.GetInt("Score").ToString();
    }
}
