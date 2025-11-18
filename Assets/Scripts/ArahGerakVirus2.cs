using UnityEngine;
using UnityEngine.Audio;

public class ArahGerakVirus2 : MonoBehaviour
{
    public float kecepatan = 2f;
    private Vector3 arah;

     public Score score;

     public AudioSource _SFXMeledak;

    public int PenaltiSkor;

    public Doctor _Doctor;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        arah = (Vector3.zero - transform.position).normalized;
        GameObject _gameObject = GameObject.FindGameObjectWithTag("Skor");
        score = _gameObject.GetComponent<Score>();
        GameObject objectDoctor = GameObject.FindGameObjectWithTag("Player");
        _Doctor = objectDoctor.GetComponent<Doctor>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(arah * kecepatan * Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("spasi");
            _SFXMeledak.Play();
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("VirusKecil")||collision.gameObject.CompareTag("VirusSedang")||collision.gameObject.CompareTag("VirusBesar"))
        {
            if (Mathf.Abs(arah.x) > Mathf.Abs(arah.y))
            {
                arah.x = -arah.x;
            }
            else
            {
                arah.y = -arah.y;
            }
            Debug.Log("Kena Virus");
            arah = arah.normalized;
        }
        if (collision.gameObject.CompareTag("DindingKiriKanan"))
        {
            Debug.Log("Kena Dinding");
            arah.x = -arah.x;
        }
        if (collision.gameObject.CompareTag("DindingAtasBawah"))
        {
            Debug.Log("Kena Dinding");
            arah.y = -arah.y;
        }
        if (collision.gameObject.CompareTag("Player"))
        {
            if (Mathf.Abs(arah.x) > Mathf.Abs(arah.y))
            {
                arah.x = -arah.x;
            }
            else
            {
                arah.y = -arah.y;
            }
            Debug.Log("Kena Dokter");
            arah = arah.normalized;
            score.KurangiSkore(PenaltiSkor);  
        }
        if (collision.gameObject.CompareTag("Peluru"))
        {
            // score.TambahSkor();
            _Doctor._EfekMledak.Play();
            Debug.Log("Harusnya putar suara");
            Destroy(gameObject);      
        }
    }

}
