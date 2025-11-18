using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NavigasiUtama : MonoBehaviour
{
    public AudioSource _BGMAwal;
    public AudioSource _SFXTombolKlik;

    public AudioSource _SFXStartGame;

    public AudioSource _SFXEndGame;

    public AudioSource _SFXExit;
    

    public Score skor;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Scene scene = SceneManager.GetActiveScene();
        if (scene.name == "GameOver")
        {
            StartCoroutine(delaySuara());           
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void BukaCredit()
    {
        _SFXTombolKlik.Play();
        SceneManager.LoadScene("Credit");
    }
    public void MainMenu()
    {
        _SFXTombolKlik.Play();
        SceneManager.LoadScene("Opening");
        skor.SimpanSkorTertinggi();
    }
    public void Exit()
    {
        skor.SimpanSkorTertinggi();
        StartCoroutine(DelayExit());
        // _SFXExit.Play();
        // // StartCoroutine(delayExit());
        // Application.Quit();
        // #if UNITY_EDITOR
        //     UnityEditor.EditorApplication.isPlaying = false;
        // #endif
    }
    public void HowTo()
    {
        _SFXTombolKlik.Play();
        SceneManager.LoadScene("HowToPlay");
    }
    public void HiScore()
    {
        _SFXTombolKlik.Play();
        SceneManager.LoadScene("HiScore");
    }
    public void Mulai()
    {
        // _SFXTombolKlik.Play();
        // _BGMAwal.Stop();
        // _SFXStartGame.Play();
        StartCoroutine(DelayPlay());
        skor.SimpanSkorTertinggi();
        SceneManager.LoadScene("Level1");
       
    }

    public IEnumerator delaySuara()
    {

        _SFXEndGame.Play();
        yield return new WaitForSeconds(2f);
        _BGMAwal.Play();
    }

    public IEnumerator DelayExit()
    {
        _BGMAwal.Stop();
        _SFXExit.Play();
        // StartCoroutine(delayExit());
        yield return new WaitForSeconds(_SFXExit.clip.length);
        Application.Quit();
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #endif
    }

    public IEnumerator DelayPlay()
    {
        _BGMAwal.Stop();
        _SFXStartGame.Play();
        // StartCoroutine(delayExit());
        yield return new WaitForSeconds(_SFXExit.clip.length);
    }



    
}
