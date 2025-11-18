using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public TMP_Text TeksSkor;

    public int Skor = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        UpdateSkor();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateSkor()
    {
        TeksSkor.text = "Skor: "+Skor;
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
}
