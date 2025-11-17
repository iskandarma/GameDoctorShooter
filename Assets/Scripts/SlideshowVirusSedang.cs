using UnityEngine;
using UnityEngine.UI;

public class SlideshowVirusSedang : MonoBehaviour
{
    public DatabaseVirusSedang databaseVirusSedang;  // tempat daftar sprite
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SetRandomSprite();
    }

    public void SetRandomSprite()
    {
        if (databaseVirusSedang.ListVirusSedang.Count == 0) return;

        int randomIndex = Random.Range(0, databaseVirusSedang.ListVirusSedang.Count);
    }
}
