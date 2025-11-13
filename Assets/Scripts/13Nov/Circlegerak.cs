using UnityEngine;

public class Circlegerak : MonoBehaviour
{
    public interaksi12B interaksi12B;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        interaksi12B.nyawa = 50;
        KurangNyawa();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        // Mengecek apakah objek yang ditabrak memiliki tag "Dinding"
        if (collision.gameObject.CompareTag("Kotak"))
        {
            Debug.Log("bola tabrak kotak");
             interaksi12B.nyawa--;

        // Memanggil fungsi KuranghNyawa() untuk memperbarui tampilan skor di layar
        KurangNyawa();
        }
       
    }
    public void KurangNyawa()
    {
        // Mengubah teks nyawa sesuai dengan nilai variabel nyawa yang ada di script interaksi12B
        interaksi12B.TeksNyawa.text = "nyawa: " + interaksi12B.nyawa.ToString();
    }
}
