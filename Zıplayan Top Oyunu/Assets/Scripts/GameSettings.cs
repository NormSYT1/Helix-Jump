using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameSettings : MonoBehaviour
{
    int score = 0;//Skor de�i�keni
    public TextMeshProUGUI score_text;//Skoru yazmak i�in gerekli de�i�ken
    public TextMeshProUGUI finalScore;//Oyun sonu skor i�in gerekli de�i�ken
    void Start()
    {
        AudioListener.volume = 1;//Oyunun ana sesi �alar
    }
    public void Game_Score(int score1)
    {
        score += score1;//Skoru artt�r
        score_text.text = "Score: " + score.ToString();//Skoru yazd�r
        finalScore.text = "Your Score: " +  score.ToString();//Oyun sonu skoru ekrana yazar
    }
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);//Bir sonraki ekrana ge�i� yapar
    }
    public void QuitGame()
    {
        Application.Quit();//Oyunu kapat�r
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("MainScene");//Ana men� ekran�na ge�i� yapar
    }
    public void PlayAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);//Mevcut ekran� tekrardan y�kler
    }
}
