using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Road : MonoBehaviour
{
    Renderer road;
    public static float timeRemaining = 0;
    public Text timeText;
    public static float speed = .2f;
    public static bool gameOver = false;

    void Start()
    {
        road = GetComponent<Renderer>();
        //timeText = GameObject.Find("Scoretext").GetComponent<Text>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Usercar.gameOver) return;
        float yOffset = Time.time * speed;
        road.material.SetTextureOffset("_MainTex", new Vector2(0f, yOffset));
        {
                timeRemaining += Time.deltaTime;
                DisplayTime(timeRemaining);
        }
    }

    float lastSecond = 0f;

    void DisplayTime(float timeToDisplay)
    {

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);

        if(seconds % 10 == 0 && lastSecond != seconds)
        {

            lastSecond = seconds;
            speed += .1f;
            Enemycarmove.speed += .002f;
        }
    }
}

