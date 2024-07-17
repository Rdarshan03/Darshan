using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemyspwan : MonoBehaviour
{
    public GameObject[] enemyCar;
    float[] carXLoc = { 1.85f,0.61f,-0.56f,-1.87f};
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("createEnemyCar", 2f, 5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void createEnemyCar()
    {

        if (Usercar.gameOver) return;
        //float startX = Random.Range(-1.8f, 1.8f);
        float startX = carXLoc[Random.Range(0,carXLoc.Length)];
        print("startX --> " + startX);
        float startY = transform.position.y;
        GameObject car = enemyCar[Random.Range(0, enemyCar.Length)];
        Instantiate(car, new Vector3(startX, startY, 90f), Quaternion.identity);
    }
}
