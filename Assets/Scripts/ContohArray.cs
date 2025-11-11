using UnityEngine;

public class ContohArray : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    /*public string[] ArrayNama = { "asep", "tono", "Budi" };
     private void Start()
    {
        Debug.Log(ArrayNama[1]);
        ArrayNama[0] = "Dimas";
        Debug.Log(ArrayNama[0]);
        
    } */
    [SerializeField]
    Player[] ArrayPlayer;
    void Start()
    {
        for (int index = 0; index < ArrayPlayer.Length; index++)
        {
            Debug.Log(ArrayPlayer[index].Name);
        }
        foreach (Player player in ArrayPlayer)
        {
            Debug.Log(player.Name);
        }
        Debug.Log(ArrayPlayer.Length);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
