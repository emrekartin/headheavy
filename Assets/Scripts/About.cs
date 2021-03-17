using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class About : MonoBehaviour
{
    public void AboutScreen()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 8);
    }
    public void BackScreen()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 8);
    }

}
