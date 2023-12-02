using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    public Text skorlabel;

    void Start()
    {
        int skor = PlayerPrefs.GetInt("skor", 0);
        skorlabel.text = skor.ToString();
    }

    public void keMenu()
    {
        SceneManager.LoadScene("Menu");

    }
}
