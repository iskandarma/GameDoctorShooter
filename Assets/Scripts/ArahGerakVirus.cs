using UnityEngine;

public class ArahGerakVirus : MonoBehaviour
{
    public float kecepatan = 2f;

    public Score score;

    private Vector3 arah;

    public int PenaltiSkor;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        arah = (Vector3.zero - transform.position).normalized;
        GameObject _gameObject = GameObject.FindGameObjectWithTag("Skor");
        score = _gameObject.GetComponent<Score>();
        // Vector2 acak = Random.insideUnitCircle.normalized;
        // arah = new Vector3(acak.x, acak.y, 0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(arah * kecepatan * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Peluru"))
        {
            // score.TambahSkor();
            Destroy(gameObject);      
        } else if (collision.gameObject.CompareTag("Player"))
        {
            score.KurangiSkore(PenaltiSkor);     
        } 
    }
}
