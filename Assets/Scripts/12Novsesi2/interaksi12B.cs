using UnityEngine;
using TMPro;

public class interaksi12B : MonoBehaviour
{
    public SquareMove12B squareMove12B;
    public int skor;
    public TMP_Text TeksSkor;
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
