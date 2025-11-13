using UnityEngine;
using TMPro;

public class interaksi12B : MonoBehaviour
{
    public SquareMove12B squareMove12B;
    // digunakan sebagai referensi ke class lain bernama SquareMove12B
    // Tujuannya agar script ini bisa berkomunikasi dengan script SquareMove12B di objek lain
    public int skor;
    // Variabel public dengan tipe data int dengan nama skor untuk menyimpan jumlah skor pemain
    public TMP_Text TeksSkor;
    // Referensi ke komponen teks TMP_Text (TextMeshPro)
    // Digunakan untuk menampilkan nilai skor di layar
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void GerakAtas()
    {
        squareMove12B.ArahGerak = ArahGerak.atas;
    }
    public void GerakBawah()
    {
        squareMove12B.ArahGerak = ArahGerak.bawah;
    }
    public void GerakKanan()
    {
        squareMove12B.ArahGerak = ArahGerak.kanan;
    }
    public void GerakKiri()
    {
        squareMove12B.ArahGerak = ArahGerak.kiri;
    }
    
    
}
