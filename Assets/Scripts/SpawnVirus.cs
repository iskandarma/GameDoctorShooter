using System.Collections;
using UnityEngine;

public class SpawnVIrus : MonoBehaviour
{
    public GameObject VirusKecil;
    public bool SedangSpawn = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(MunculkanObject());

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator MunculkanObject()
    {
        while(SedangSpawn == true)
        {
            Vector3 PosisiSpawn = Vector3.zero;
            int sisi = Random.Range(0, 4); // 0=atas,1=bawah,2=kiri,3=kanan

            float xMin = Camera.main.ScreenToWorldPoint(Vector3.zero).x;
            float xMax = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, 0, 0)).x;
            float yMin = Camera.main.ScreenToWorldPoint(Vector3.zero).y;
            float yMax = Camera.main.ScreenToWorldPoint(new Vector3(0, Screen.height, 0)).y;

            switch (sisi)
            {
                case 0: PosisiSpawn = new Vector3(Random.Range(xMin, xMax), yMax, 0); break; // atas
                case 1: PosisiSpawn = new Vector3(Random.Range(xMin, xMax), yMin, 0); break; // bawah
                case 2: PosisiSpawn = new Vector3(xMin, Random.Range(yMin, yMax), 0); break; // kiri
                case 3: PosisiSpawn = new Vector3(xMax, Random.Range(yMin, yMax), 0); break; // kanan
            }
            Instantiate(VirusKecil, PosisiSpawn, Quaternion.identity);
            yield return new WaitForSeconds(2);
        }
    }
}
