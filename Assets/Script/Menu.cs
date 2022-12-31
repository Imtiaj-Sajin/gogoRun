using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
   
    public void StartGame()
    {
       
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
        //FindObjectOfType<score>().ResetHighScore();
        
        
    }
    public void Lv2()
    {
       
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +2);
        //FindObjectOfType<score>().ResetHighScore();
        
        
    }
    public void Lv3()
    {
       
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +3);
    }
    public void Lv4()
    {
       
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +4);
    }
}
