using UnityEngine;
using UnityEngine.UI;

public class SlideshowVirusKecil : MonoBehaviour
{
    public DatabaseVirusKecil databaseVirusKecil;  // tempat daftar sprite
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SetRandomSprite();
    }

    public void SetRandomSprite()
    {
        if (databaseVirusKecil.ListVirusKecil.Count == 0) return;

        int randomIndex = Random.Range(0, databaseVirusKecil.ListVirusKecil.Count);
    }
}
