using UnityEngine;
using UnityEngine.UI;

public class SlideshowVirusBesar : MonoBehaviour
{
    public DatabaseVirusBesar databaseVirusBesar;  // tempat daftar sprite
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SetRandomSprite();
    }

    public void SetRandomSprite()
    {
        if (databaseVirusBesar.ListVirusBesar.Count == 0) return;

        int randomIndex = Random.Range(0, databaseVirusBesar.ListVirusBesar.Count);
    }
}
