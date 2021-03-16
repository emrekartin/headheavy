using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class game : MonoBehaviour
{
    private int currentPoint = 0;
    private string text_point = "";
    public static bool inSight = false;
    // Start is called before the first frame update
    void Awake()
    {
        PointScreen();

    }

    // Update is called once per frame
    void Update()
    {
        
        if (GameObject.FindGameObjectWithTag("ball").transform.position.x > 6.817 && GameObject.FindGameObjectWithTag("ball").transform.position.x < 7.872)
        {
         
            
                if (GameObject.FindGameObjectWithTag("ball").transform.position.y < 0.490 && GameObject.FindGameObjectWithTag("ball").transform.position.y > 0.480)
                {

                Debug.Log("dadae");
                currentPoint++;
                PointScreen();
            }
        }
    }

    void PointScreen()
    {
        text_point = "" + currentPoint;
        GameObject.FindGameObjectWithTag("Point").GetComponent<TextMesh>().text = text_point;
    }
   

}
