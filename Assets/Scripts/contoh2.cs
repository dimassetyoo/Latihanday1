using UnityEngine;

public class contoh2 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int age = 17;
        int money = 50000;
        if (age >= 18 || money >= 100000)
        {
            Debug.Log("dapat masuk");
        }
        else
        {
            Debug.Log("tidak bisa masuk");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
