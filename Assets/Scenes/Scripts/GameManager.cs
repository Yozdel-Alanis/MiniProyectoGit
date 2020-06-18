using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{   
    public Text coinText;
    public Text LlaveText;

    int coins;
    int keys;
    int llaves;

    public void AddCoin()
    {
        coins++;
        Debug.Log("Coins: " + coins);
        coinText.text = "Coins: " + coins;
    }

    public void AddLlaves()
    {
        llaves++;
        Debug.Log("llaves: " + llaves);
        LlaveText.text = "llaves: " + llaves;
    }

    public void AddKey()
    {
        keys++;
    }

    public void ConsumeKey()
    {
        keys--;
    }

    public bool HasKey()
    {
        if (keys > 0)
            return true;
        else
            return false;
    }

    // private void Update()
  //  {
//        coinText.text = "Time" + Time.timeSinceLevelLoad;
   
     //   llavesText.text = "Time" + Time.timeSinceLevelLoad;
    // } 
    public void GameOver()
    {
        Debug.Log("Game Over");

    }

    public void GameWin()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
