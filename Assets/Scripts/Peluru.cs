using UnityEngine;

public class Peluru : MonoBehaviour
{
    public float Kecepatan = 5.0f;

    public float WaktuPeluru = 3.0f;

    public int skorVirusKecil;
    public int skorVirusSedang;
    public int skorVirusBesar;

    // public AudioSource _SFXMeledak;

    public Score score;

    void Start()
    {
        // untuk menghapus peluru
        Destroy(gameObject, WaktuPeluru);
        GameObject _gameObject = GameObject.FindGameObjectWithTag("Skor");
        score = _gameObject.GetComponent<Score>();
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
            // _SFXMeledak.Play();
            score.TambahSkor(skorVirusKecil);
            Destroy(gameObject);      
        } else if (collision.gameObject.CompareTag("VirusSedang"))
        {
            // _SFXMeledak.Play();
            score.TambahSkor(skorVirusSedang);
            Destroy(gameObject);   
        } else if (collision.gameObject.CompareTag("VirusBesar")){
            // _SFXMeledak.Play();
            score.TambahSkor(skorVirusBesar);
            Destroy(gameObject); 
        }
    }

}
