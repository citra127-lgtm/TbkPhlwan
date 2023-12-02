using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour
{
    public void keGame()
    {

        SceneManager.LoadScene("Gamescene");
    }


    public void keSkorMenu()
    {

        SceneManager.LoadScene("Skormenu");
    }
    public void keLuar()
    {

        Application.Quit();

    }

}
