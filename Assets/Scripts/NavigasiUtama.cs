using UnityEngine;
using UnityEngine.SceneManagement;

public class NavigasiUtama : MonoBehaviour
{
    public AudioSource _BGMAwal;
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
        Application.Quit();
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #endif
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
