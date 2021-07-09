using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

using UnityEngine.SceneManagement;
public class Pot : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject.Find("ground (1)").GetComponent<BoxCollider2D>().isTrigger = false;
        StartCoroutine(WaitForLevelSwitch());
    }

    IEnumerator WaitForLevelSwitch()
    {
        yield return new WaitForSeconds(1);
        GameObject.Find("result").GetComponent<TextMesh>().text = "Excellent";
        GameObject.Find("result").GetComponent<MeshRenderer>().enabled = true;
        
        
        StartCoroutine(WaitForLevelSwitch1());
    }
    IEnumerator WaitForLevelSwitch1()
    {
        yield return new WaitForSeconds(4);
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}