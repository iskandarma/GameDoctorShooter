using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public float kecepatan = 2f;
    private Vector3 arah;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        arah = (Vector3.zero - transform.position).normalized;
        // Vector2 acak = Random.insideUnitCircle.normalized;
        // arah = new Vector3(acak.x, acak.y, 0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(arah * kecepatan * Time.deltaTime);
    }
}
