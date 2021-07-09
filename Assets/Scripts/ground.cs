using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

using System;
public class Ground : MonoBehaviour
{
    public GameObject hexagons;
    static Ground instance;
    private static GameObject playerInstance;
    private int currentPoint;
    private string text_point = "";
    void Awake()
    {
        Instantiate(hexagons, Vector3.zero, Quaternion.identity);
        //DontDestroyOnLoad();
     }
    void Start()
    {
        GameObject.Find("buttons(Clone)").GetComponent<Canvas>().worldCamera = Camera.main;
        currentPoint = Convert.ToInt32(GameObject.Find("Point").GetComponent<TextMesh>().text);
        //Destroy(GameObject.Find(""))
        Debug.Log(SceneManager.GetActiveScene().name);
        
    }
    
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "ball")
        {
            currentPoint++;
            text_point = "" + currentPoint;
            GameObject.Find("Point").GetComponent<TextMesh>().text = text_point;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        
    }
}
