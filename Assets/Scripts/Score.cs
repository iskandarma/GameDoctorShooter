using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public TMP_Text TeksSkor;

    public TMP_Text TeksHiSkor;

    public int Skor;

    public int HighScore;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // UpdateSkor();
        Skor = PlayerPrefs.GetInt("SkorSekarang");
        HighScore = PlayerPrefs.GetInt("HighScore");
        TeksSkor.text = "Skor: " + Skor.ToString();
        TeksHiSkor.text = HighScore.ToString();
        PlayerPrefs.DeleteKey("SkorSekarang");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateSkor()
    {
        TeksSkor.text = "Skor: "+Skor;
        PlayerPrefs.SetInt("SkorSekarang", Skor);
        PlayerPrefs.Save();
        Debug.Log("Skore diupdate");
    }

    public void TambahSkor(int amountSkor)
    {
        // Skor++;
        Skor += amountSkor;
        UpdateSkor();
        Debug.Log("Skore bertambah");
    }

    public void KurangiSkore(int amountSkor)
    {
        // Skor--;
        Skor -= amountSkor;
        UpdateSkor();
        Debug.Log("Skore berkurang");
    }

    public void SimpanSkorTertinggi()
    {
        if (Skor > HighScore)
        {
            HighScore = Skor;
            PlayerPrefs.SetInt("HighScore", HighScore);
            PlayerPrefs.Save();
        }
    }

}
