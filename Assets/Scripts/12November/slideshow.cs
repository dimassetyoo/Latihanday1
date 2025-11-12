using UnityEngine;
using UnityEngine.UI;

public class slideshow : MonoBehaviour
{
    public Databasegambar databasegambar;
    public Image objectImage;
    public int index = 0;
    public void Next()
    {
         if (index >= databasegambar.ListGambar.Count - 1 )
        {
            index = 0;
        }
        else
        {
             index = index + 1;      
        }     
        objectImage.sprite = databasegambar.ListGambar[index];
    }
    public void Previous()
    {
        if (index <= 0)
        {
            index = databasegambar.ListGambar.Count - 1;
        }
        else
        {
             index = index - 1;      
        }
        objectImage.sprite = databasegambar.ListGambar[index];
    }
}
