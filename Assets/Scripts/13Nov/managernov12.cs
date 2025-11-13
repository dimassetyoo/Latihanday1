using System.Data.Common;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class managernov12 : MonoBehaviour
{

    public squaremove13nov squaremove13nov;
    public int skor;
    public TMP_Text TeksSkor;
    public GameObject bolaJatuh; //variabel referensi prefab yang akan jatuh
    public pemainlompat pemainlompat;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("klik kiri");
            // Vector3 vector = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            //Debug.Log("Posisi mouse ada di " + vector.ToString());
            TambahSkor();
            UpdateTeksSkor();
            // ToggleKiriKanan();
            squaremove13nov.isMoveRight = false;
            MunculDariAtas();
            pemainlompat.Lompat();
        }
        if (Input.GetMouseButtonDown(1))
        {
            Debug.Log("klik kanan");
            KurangSkor();
            UpdateTeksSkor();
            squaremove13nov.isMoveRight = true;
        }
    }
    void TambahSkor()
    {
        skor++;
        Debug.Log("int skor bertambah");
    }
    void KurangSkor()
    {
        skor--;
        Debug.Log("int skor berkurang");
    }
    void UpdateTeksSkor()
    {
        TeksSkor.text = skor.ToString();
        Debug.Log("text skor berubah");
    }
    void ToggleKiriKanan()
    {
        if (squaremove13nov.isMoveRight)
        {
            squaremove13nov.isMoveRight = false;
        }
        else
        {
            squaremove13nov.isMoveRight = true;
        }
    }
void MunculDariAtas()
        {
        Vector3 posisiKlik = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3 titikAtas = Camera.main.ScreenToWorldPoint(new Vector3(0, Screen.height, 0));
        Vector3 tempatJatuh = new Vector3(posisiKlik.x, titikAtas.y, 0);

        Instantiate(bolaJatuh, tempatJatuh, Quaternion.identity);
    }

    
}
    
