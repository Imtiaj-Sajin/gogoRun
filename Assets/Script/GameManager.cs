using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    bool x=false;
    public float restartDelay=1f;
    public GameObject completeLevelUI,scoreUI;

    public void Success()
    {
        completeLevelUI.SetActive(true);
        scoreUI.SetActive(false);
    }
    public void EndGame()
    {
        if(x==false)
        {
            x=true;
            Debug.Log("Game OVER");  
            Invoke("Restart",restartDelay);
        }
    }
void Restart()
{
    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
}








}
