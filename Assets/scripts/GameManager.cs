using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager gm;
    bool gameHasEnded = false;
    public float RestartDelay=1f;
    public GameObject GameOverUI;
    public Text scoretext;
    public Text DisplayText;
    public int score=0;

    private void Start()
    {
        if(gm == null)
        {
            gm = gameObject.GetComponent<GameManager>();
        }
    }

    public void Scorexx()
    {
        score+=1;
        scoretext.text = score.ToString();
    }
    public void LevelEnd()
    {
        DisplayText.text = scoretext.text;
        GameOverUI.SetActive(true);
    }
    public void EndGame()
    {
        if(gameHasEnded==false)
        {
            gameHasEnded = true;
            LevelEnd();
            // Restart();
        }
    }
    public void Restart()
    {
       SceneManager.LoadScene("Level1");
    }
}
