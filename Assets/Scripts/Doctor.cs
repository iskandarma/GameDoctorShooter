using System.Collections;
using UnityEngine;
using UnityEngine.Audio;

public class Doctor : MonoBehaviour
{
   
    public GameObject Peluru;

    public Transform ArahTembak;

    public int JumlahMaksimalPeluru = 1;

    private float Timer = 0f;

    private int JumlahTembakan;

    public AudioSource _EfekTembak;

    // Update is called once per frame
    void Update()
    {
        Vector3 worldMousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        // agar tidak menggunakan z dari mouse position
        worldMousePosition.z = 0;
        
        // Hitung arah dari objek ke mouse
        Vector3 direction = worldMousePosition - transform.position;
        
        // Hitung sudut rotasi dalam derajat
        float SudutDokter = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        
        // mengubah rotasi dokter sesuai dengan posisi mouse
        transform.rotation = Quaternion.Euler(0f, 0f, SudutDokter);

        Timer += Time.deltaTime;

        //reset hitung setiap 1 detik
        if (Timer >= 1f)
        {
            Timer = 0f;
            JumlahTembakan = 0;
        }

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (JumlahTembakan < JumlahMaksimalPeluru)
            {
                TembakPeluru();
                JumlahTembakan++;
            }
        }
    }

    void TembakPeluru()
    {
        Instantiate(Peluru, ArahTembak.position, ArahTembak.rotation);
        _EfekTembak.Play();
    }

}
