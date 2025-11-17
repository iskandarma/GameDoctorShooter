using UnityEngine;

public class Peluru : MonoBehaviour
{
    public float Kecepatan = 5.0f;

    public float WaktuPeluru = 3.0f;

    void Start()
    {
        // untuk menghapus peluru
        Destroy(gameObject, WaktuPeluru);
    }

    // Update is called once per frame
    void Update()
    {
        // untuk mengatur gerak peluru
        transform.Translate(Vector3.right * Kecepatan * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // ketika peluru menabrak Virus
        if (collision.gameObject.CompareTag("VirusKecil"))
        {
            Destroy(gameObject);      
        }
    }

}
