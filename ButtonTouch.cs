using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonTouch : MonoBehaviour
{
    public int Buttontype = 0;
    public GameObject userCar;
    float moveIffset = 0.005f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Usercar.gameOver) return;
        // print("----> ButtonTouch  --->  "+ Input.GetKey(KeyCode.DownArrow));
        if (Buttontype == 4)
        {
            if (Input.GetMouseButton(0) || Input.GetKey(KeyCode.DownArrow))
            {
                Vector3 position = userCar.transform.position;
                position.y = Mathf.Max(position.y - moveIffset, -4.2f);
                userCar.transform.position = position;
            }
        }
        else
        if (Buttontype == 3)
        {
            if (Input.GetMouseButton(0) || Input.GetKey(KeyCode.UpArrow))
            {
                Vector3 position = userCar.transform.position;
                position.y = Mathf.Min(position.y + moveIffset, 4.2f);
                userCar.transform.position = position;
            }
        }
        else
        if (Buttontype == 1)
        {
            if (Input.GetMouseButton(0) || Input.GetKey(KeyCode.LeftArrow))
            {
                //print("buttonType  -->  it's change" );
                Vector3 position = userCar.transform.position;
                position.x = Mathf.Max(position.x - moveIffset, -1.9f);
                userCar.transform.position = position;
            }
        }
        else
        if (Buttontype == 2)
        {
            if (Input.GetMouseButton(0) || Input.GetKey(KeyCode.RightArrow))
            {
                Vector3 position = userCar.transform.position;
                position.x = Mathf.Min(position.x + moveIffset, 1.9f);
                userCar.transform.position = position;
            }
        }
    }
}
