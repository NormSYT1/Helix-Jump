using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameSettings : MonoBehaviour
{
    int score = 0;//Skor deðiþkeni
    public TextMeshProUGUI score_text;//Skoru yazmak için gerekli deðiþken
    public TextMeshProUGUI finalScore;//Oyun sonu skor için gerekli deðiþken
    void Start()
    {
        AudioListener.volume = 1;//Oyunun ana sesi çalar
    }
    public void Game_Score(int score1)
    {
        score += score1;//Skoru arttýr
        score_text.text = "Score: " + score.ToString();//Skoru yazdýr
        finalScore.text = "Your Score: " +  score.ToString();//Oyun sonu skoru ekrana yazar
    }
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);//Bir sonraki ekrana geçiþ yapar
    }
    public void QuitGame()
    {
        Application.Quit();//Oyunu kapatýr
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("MainScene");//Ana menü ekranýna geçiþ yapar
    }
    public void PlayAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);//Mevcut ekraný tekrardan yükler
    }
}
