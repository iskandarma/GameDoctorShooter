using UnityEngine;

public class RandomMover : MonoBehaviour
{
    public RectTransform uiObject;

    public float speed = 100f;  
    public float range = 50f;   // jarak dari posisi awal

    private Vector2 direction;
    private Vector2 startPos;

    void Start()
    {
        startPos = uiObject.anchoredPosition;

        // arah awal random
        direction = Random.insideUnitCircle.normalized;
    }

    void Update()
    {
        // gerakkan UI
        uiObject.anchoredPosition += direction * speed * Time.deltaTime;

        Vector2 pos = uiObject.anchoredPosition;

        // batas posisi berdasarkan startPos ± range
        float minX = startPos.x - range;
        float maxX = startPos.x + range;
        float minY = startPos.y - range;
        float maxY = startPos.y + range;

        // mantul X
        if (pos.x <= minX || pos.x >= maxX)
            direction.x = -direction.x;

        // mantul Y
        if (pos.y <= minY || pos.y >= maxY)
            direction.y = -direction.y;
    }
}