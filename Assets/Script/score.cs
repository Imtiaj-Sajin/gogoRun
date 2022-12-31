using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class score : MonoBehaviour
{
    public Transform player;
    public TextMeshProUGUI scoreText,highScore;
    public Collision collisionInfo;
    
    void Start()
    {
         highScore.text=PlayerPrefs.GetInt("HighScore",0).ToString();
    }
        
    void Update()
    {/*int number=0;
        string normText;
       normText=player.position.z.ToString("0");
       number=int.Parse(normText)+number;
        scoreText.text=number.ToString();*/
        scoreText.text=player.position.z.ToString("0");
        int  number=int.Parse(scoreText.text);
        

     if(number>PlayerPrefs.GetInt("HighScore",0)) 
      {
           PlayerPrefs.SetInt("HighScore",number);
           highScore.text=number.ToString();
      }
    }
    public void ResetHighScore()
    {
        PlayerPrefs.DeleteAll();
        highScore.text="0";
        
    }
   
}
    