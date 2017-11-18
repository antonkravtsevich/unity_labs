using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreController : MonoBehaviour {
    private int score;
    public int CubeCount;
    public Text UItext;

    public void Start()
    {
        score = 0;

        UItext.text = "Score: " + score.ToString() + "\nCubes left: " + CubeCount.ToString();
    }

    public void OnTriggerEnter(Collider other)
    {
        GameObject go = other.gameObject;
        if (go.name == "ScoreCube")
        {
            score += 100;
            CubeCount--;
            UItext.text = "Score: " + score.ToString() + "\nCubes left: " + CubeCount.ToString();

            if(CubeCount == 0)
            {
                SceneManager.LoadScene(1);
            }
        }
    }
}
