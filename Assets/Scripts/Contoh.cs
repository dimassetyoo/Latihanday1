using System.Collections;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.Timeline;

public class Contoh : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /*  int Number1 = 10;
         int Number2 = 7;
         int temp = Number1;
         Number1 = Number2;
         Number2 = temp;
         Debug.Log(Number2);
         Debug.Log(Number1); */
        /* int number = 3;
         switch (number)
         {
             case 1:
                 Debug.Log("Basic Sword");
                 break;
             case 2:
                 Debug.Log("Electric Bow");
                 break;
             case 3:
                 Debug.Log("Fire Spell");
                 break;
         } */
        Debug.Log(kali(5, 10, 5));
         
    }
    public int kali( int angka1, int angka2, int angka3)
    {
        int result = angka1 * angka2 * angka3;
        return result;
    }
    // Update is called once per frame
    void Update()
    {
       
    }
}
