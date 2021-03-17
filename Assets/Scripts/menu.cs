using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
	public void PlayGame()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}
	public void Challange1()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}
	public void Challange2()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
	}
	public void Challange3()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
	}
	public void Challange4()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4);
	}
	public void Challange5()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 5);
	}
	public void Challange6()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 6);
	}

	public void ReturnMenu()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
	}
	public void howtoplayscreen()
    {
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +9);
	}
	
	public void returnmeunufromhowtoplayscreen()
    {
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -9);
	}

	public void returnmeunufromaboutscreen()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 8);
	}
}
