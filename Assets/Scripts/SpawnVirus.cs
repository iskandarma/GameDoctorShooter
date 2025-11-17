using System.Collections;
using UnityEngine;

public class SpawnVIrus : MonoBehaviour
{
    public GameObject VirusKecil;
    public GameObject VirusSedang;
    public GameObject VirusBesar;
    public bool SedangSpawn = true;
    public DatabaseVirusKecil databaseVirusKecil;
    public DatabaseVirusSedang databaseVirusSedang;
    public DatabaseVirusBesar databaseVirusBesar;
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

            // Pilih jenis virus acak
            int jenis = Random.Range(0, 3); // 0=kecil,1=sedang,2=besar
            GameObject JenisVirus = VirusKecil;
            DatabaseVirusKecil dbKecil = null;
            DatabaseVirusSedang dbSedang = null;
            DatabaseVirusBesar dbBesar = null;

            switch (jenis)
            {
                case 0: 
                    JenisVirus = VirusKecil; dbKecil = databaseVirusKecil; 
                    break;
                case 1: 
                    JenisVirus = VirusSedang; dbSedang = databaseVirusSedang; 
                    break;
                case 2: 
                    JenisVirus = VirusBesar; dbBesar = databaseVirusBesar; 
                    break;
            }

            // Spawn virus
            GameObject virus = Instantiate(JenisVirus, PosisiSpawn, Quaternion.identity);

            // Pilih sprite acak sesuai jenis
            if (jenis == 0 && dbKecil != null && dbKecil.ListVirusKecil.Count > 0)
            {
                int index = Random.Range(0, dbKecil.ListVirusKecil.Count);
                virus.GetComponent<SpriteRenderer>().sprite = dbKecil.ListVirusKecil[index];
            }
            else if (jenis == 1 && dbSedang != null && dbSedang.ListVirusSedang.Count > 0)
            {
                int index = Random.Range(0, dbSedang.ListVirusSedang.Count);
                virus.GetComponent<SpriteRenderer>().sprite = dbSedang.ListVirusSedang[index];
            }
            else if (jenis == 2 && dbBesar != null && dbBesar.ListVirusBesar.Count > 0)
            {
                int index = Random.Range(0, dbBesar.ListVirusBesar.Count);
                virus.GetComponent<SpriteRenderer>().sprite = dbBesar.ListVirusBesar[index];
            }

            yield return new WaitForSeconds(1.5f);
            }
    }
}
