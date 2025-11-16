using UnityEngine;

public class Doctor : MonoBehaviour
{
    public Vector3 ArahSenjataDokter;
    public Transform DokterTransform;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 worldMousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        // agar tidak menggunakan z dari mouse position
        worldMousePosition.z = 0;
        
        // Hitung arah dari objek ke mouse
        Vector3 direction = worldMousePosition - transform.position;
        
        // Hitung sudut rotasi dalam derajat
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        
        // mengubah rotasi dokter sesuai dengan posisi mouse
        transform.rotation = Quaternion.Euler(0f, 0f, angle);
    }


}
