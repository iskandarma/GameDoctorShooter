using UnityEngine;

public class ArahGerakVirus2 : MonoBehaviour
{
    public float kecepatan = 2f;
    private Vector3 arah;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        arah = (Vector3.zero - transform.position).normalized;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(arah * kecepatan * Time.deltaTime);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Virus"))
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
        }
    }
}
