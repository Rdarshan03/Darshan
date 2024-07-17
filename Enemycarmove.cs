using System;
using UnityEngine;
using UnityEngine.UI;

public class Enemycarmove : MonoBehaviour
{
    Boolean  scorecounted;
    public static int Score;
    public Text Scoretext;
    public static float startSpeed = .004f;
    public static float speed = startSpeed;

    void Start()
    {
        Scoretext = GameObject.Find("Scoretext").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Usercar.gameOver) return;
        float offset = speed;
        float yPosition = transform.position.y - offset;
        transform.position = new Vector3(transform.position.x, yPosition, transform.position.z);
        if(yPosition < -3.30 && !scorecounted)
        {

            addScore();
            scorecounted = true;

        }
    }

    public void addScore()
    {
        if (Usercar.gameOver) return;

        Score++;
        //print("score  --->  "+Score);
        Scoretext.text = ""+Score;
    }
}
