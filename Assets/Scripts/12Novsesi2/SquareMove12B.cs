using UnityEngine;
using Unity.VisualScripting;
using UnityEditor.Rendering;
using TMPro;

public class SquareMove12B : MonoBehaviour
{
    public ArahGerak ArahGerak = ArahGerak.kanan;
    public interaksi12B interaksi12B;
    public float kecepatan = 5.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        switch (ArahGerak)
        {
            case ArahGerak.atas:
                gameObject.transform.Translate(0, kecepatan * Time.deltaTime, 0);
                break;
            case ArahGerak.bawah:
                gameObject.transform.Translate(0, -kecepatan * Time.deltaTime, 0);
                break;
            case ArahGerak.kanan:
                gameObject.transform.Translate(kecepatan * Time.deltaTime, 0, 0);
                break;
            case ArahGerak.kiri:
                gameObject.transform.Translate(-kecepatan * Time.deltaTime, 0, 0);
                break;
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Dinding"))
        {
            if (ArahGerak == ArahGerak.atas)
            {
                ArahGerak = ArahGerak.bawah;
                Debug.Log("tabrak dinding atas");
            }
            else if (ArahGerak == ArahGerak.bawah)
            {
                ArahGerak = ArahGerak.atas;
                Debug.Log("tabrak dinding bawah");
            }
            else if (ArahGerak == ArahGerak.kanan)
            {
                ArahGerak = ArahGerak.kiri;
                Debug.Log("tabrak dinding kanan");
            }
            else
            {
                ArahGerak = ArahGerak.kanan;
                Debug.Log("tabrak dinding kiri");
            }
            interaksi12B.skor++;
            TambahSkor();
        }
    }
    public void TambahSkor()
    {
        interaksi12B.TeksSkor.text = "skor:" + interaksi12B.skor.ToString();
    }
}

public enum ArahGerak
{
    diam,
    atas,
    bawah,
    kanan,
    kiri,
}
