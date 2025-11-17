using UnityEngine;
using UnityEngine.SceneManagement;

public class NavigasiUtama : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void BukaCredit()
    {
        SceneManager.LoadScene("Credit");
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("Opening");
    }
    public void Exit()
    {
        SceneManager.LoadScene("Exit");
    }
    public void HowTo()
    {
        SceneManager.LoadScene("HowToPlay");
    }
    public void HiScore()
    {
        SceneManager.LoadScene("HiScore");
    }
    public void Mulai()
    {
        SceneManager.LoadScene("Level1");
    }
}
