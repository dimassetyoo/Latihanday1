using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Aksitombol : MonoBehaviour
{

  // image adalah komoponen dari object image yang ada di dalam scene    
    public Image image;
    // sprite adalah aset gambar yang ingin dimasukkan ke image
    public Sprite assetGambar;
    public TMP_Text objectText; 
    public void Aksi()
    {
        /* image.sprite = assetGambar;
         objectText.text = "Berbasis IOT";
         Debug.Log("Tombol Diklik"); */
        SceneManager.LoadScene("Day3NewScene");
    }
}
