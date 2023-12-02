using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GamePlay : MonoBehaviour
{
    int skor = 0;

    

    public void kemenu()
    {
        //perintah untuk pindah scene
        SceneManager.LoadScene("Menu");
    }
    public void keSkor()
    {
        //perintah untuk pindah scene
        SceneManager.LoadScene("Skormenu");
    }

    public void jawabBenar()
    {
        //menambah skor per satu skor
        skor++;
        //menyimpan sementara skor ke dalam memori
        PlayerPrefs.SetInt("skor", skor);
        print(skor);
    }
}
