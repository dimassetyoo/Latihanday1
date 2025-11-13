using UnityEngine;

public class squaremove13nov : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public bool isMoveRight = true;
    public float kecepatan = 5.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isMoveRight == true)
        {
            //kanan
            gameObject.transform.Translate(kecepatan * Time.deltaTime, 0, 0);

        }
        else
        {
            //kiri
            gameObject.transform.Translate(-kecepatan * Time.deltaTime, 0, 0);
        }
            
    }
}
