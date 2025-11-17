using System.Collections;
using NUnit.Framework;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{

    public TMP_Text TeksTimer;

    public float Waktu;

    public float MaksimumWaktu;

    public bool isPause = false;

    public bool isOver = false;

    public KeyCode PauseGameKey;

    public Coroutine HitungTimerCoroutine;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        HitungTimerCoroutine = StartCoroutine(HitungTimer());
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(PauseGameKey))
        {
            Debug.Log("tombol pause ditekan");
            if (!isPause)
            {
                PauseGame();
            } else
            {
                ResumeGame();
            }
        }
    }

    public void PauseGame()
    {
        SceneManager.LoadScene("Pause", LoadSceneMode.Additive);
        Time.timeScale = 0f;
        isPause=true;
    }

    public void ResumeGame()
    {
        SceneManager.UnloadSceneAsync("Pause");
        Time.timeScale = 1f;
        isPause=false;
    }

    IEnumerator HitungTimer()
    {
        while(true)
        {
            if (!isOver)
            {
                if (!isPause)
                {
                    if(Waktu > 0)
                    {
                        Waktu--;
                        TeksTimer.text = Waktu.ToString();                  
                    } else
                    {
                        isOver = true;
                        Debug.Log("Game is Over");
                        SceneManager.LoadScene("GameOver");
                    }
                }
            }
            
            yield return new WaitForSeconds(1);
        }
    }
}
