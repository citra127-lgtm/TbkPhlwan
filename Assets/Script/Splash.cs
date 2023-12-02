using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Splash : MonoBehaviour
{
    public GameObject musik;
    void Start()
    {
        DontDestroyOnLoad(musik);
    }


    public void mulai()
    {
        SceneManager.LoadScene("Menu");
    }
}
