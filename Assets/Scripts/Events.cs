using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;
public class Events : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (GameObject.Find("buttons(Clone)"))
        {
            if (SceneManager.GetActiveScene().name == "Menu")
                GameObject.Find("buttons(Clone)").GetComponent<Canvas>().enabled = false;
            else if (SceneManager.GetActiveScene().name == "About")
                GameObject.Find("buttons(Clone)").GetComponent<Canvas>().enabled = false;
            else if (SceneManager.GetActiveScene().name == "Challenge Menu")
                GameObject.Find("buttons(Clone)").GetComponent<Canvas>().enabled = false;
            else if (SceneManager.GetActiveScene().name == "HowtoPlay")
                GameObject.Find("buttons(Clone)").GetComponent<Canvas>().enabled = false;
            else
            {

                GameObject.Find("buttons(Clone)").GetComponent<Canvas>().enabled = true;
            }
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
