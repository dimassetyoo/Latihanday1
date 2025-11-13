using UnityEngine;
using Unity.VisualScripting;
using UnityEditor.Rendering;
using TMPro;

public class SquareMove12B : MonoBehaviour
{
    
    public ArahGerak ArahGerak = ArahGerak.kanan;
    // Membuat variabel publik bertipe enum ArahGerak, dengan nilai awal = kanan
    // Enum ArahGerak berisi arah gerak: atas, bawah, kiri, kanan
    // Variabel ini akan menentukan arah gerak awal dari GameObject
    // Misalnya jika diatur ke kanan, maka objek akan langsung bergerak ke kanan saat game dimulai


    public interaksi12B interaksi12B;
    // digunakan sebagai referensi ke class lain bernama interaksi12B
    // Tujuannya agar script ini bisa berkomunikasi dengan script interaksi12B di objek lain
    // Setelah deklarasi ini, objek yang memiliki script interaksi12B harus di-*assign* di Inspector Unity


    public float kecepatan = 5.0f;
    // Variabel publik dengan class kecepatan
    // objek akan bergerak dengan kecepatan 5 unit per detik (disesuaikan oleh Time.deltaTime)

    void Start()
    {

    }

    void Update()
    {
        // Switch merupakan percabangan yang digunakan untuk menentukan arah gerak berdasarkan enum ArahGerak
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
        // Time.deltaTime digunakan agar gerakan tetap halus dan konsisten pada setiap frame,
    }

    // Fungsi ini otomatis dijalankan saat objek bertabrakan dengan objek lain yang memiliki Collider2D
    void OnCollisionEnter2D(Collision2D collision)
    {
        // Mengecek apakah objek yang ditabrak memiliki tag "Dinding"
        if (collision.gameObject.CompareTag("Dinding"))
        {
            // Jika objek bergerak ke atas dan menabrak dinding, maka arah diganti ke bawah
            if (ArahGerak == ArahGerak.atas)
            {
                ArahGerak = ArahGerak.bawah;
                Debug.Log("tabrak dinding atas");
            }
            // Jika objek bergerak ke bawah dan menabrak dinding, arah diganti ke atas
            else if (ArahGerak == ArahGerak.bawah)
            {
                ArahGerak = ArahGerak.atas;
                Debug.Log("tabrak dinding bawah");
            }
            // Jika objek bergerak ke kanan dan menabrak dinding, arah diganti ke kiri
            else if (ArahGerak == ArahGerak.kanan)
            {
                ArahGerak = ArahGerak.kiri;
                Debug.Log("tabrak dinding kanan");
            }
            // Jika objek bergerak ke kiri dan menabrak dinding, arah diganti ke kanan
            else
            {
                ArahGerak = ArahGerak.kanan;
                Debug.Log("tabrak dinding kiri");
            }

            // Menambahkan skor setiap kali menabrak dinding
            interaksi12B.skor++;

            // Memanggil fungsi TambahSkor() untuk memperbarui tampilan skor di layar
            TambahSkor();
        }
    }

    // Fungsi untuk memperbarui teks skor di layar
    public void TambahSkor()
    {
        // Mengubah teks skor sesuai dengan nilai variabel skor yang ada di script interaksi12B
        interaksi12B.TeksSkor.text = "skor: " + interaksi12B.skor.ToString();
    }
}
// Enum (enumeration) digunakan untuk membuat kumpulan nilai tetap yang mudah dibaca
// Enum ArahGerak digunakan untuk menentukan arah gerak objek
public enum ArahGerak
{
    diam,
    atas,
    bawah,
    kanan,
    kiri,
}
