using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Usercar : MonoBehaviour
{

    public static bool gameOver = false;
    float moveIffset = 0.01f;
    public GameObject GameOverPopup;
    


    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {

    }
  
    private void OnTriggerEnter2D(Collider2D collision)
    {

        //print("OnTriggerEnter2D ---> "+collision.tag);
        gameOver = true;
        GameOverPopup.SetActive(true);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //print("OnCollisionEnter2D");
    }

    public void Btnstart()
    {
        gameOver = false;
        GameOverPopup.SetActive(false);
        GameObject[] respawns = GameObject.FindGameObjectsWithTag("EnemyCarYellow");
        //print("length --->" + respawns.Length);
        for (int i = 0; i < respawns.Length; i++)
        {
            respawns[i].transform.position = new Vector3();
            DestroyImmediate(respawns[i].gameObject);
        }
        transform.position = new Vector3(0f, -2.72f, 0f);
        Enemycarmove.Score = 0;
        Road.timeRemaining = 0;
        Road.speed = .2f;
        Enemycarmove.speed = Enemycarmove.startSpeed;
        GameObject.Find("Scoretext").GetComponent<Text>().text = "" + Enemycarmove.Score;
        GameObject.Find("TimerText").GetComponent<Text>().text = "" + Road.timeRemaining;

    }

}
