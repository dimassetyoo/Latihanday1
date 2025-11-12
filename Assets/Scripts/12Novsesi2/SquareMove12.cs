using UnityEngine;

public class SquareMove : MonoBehaviour
{
    public bool isMoveRight = true;
    public float kecepatan = 5.0f;
    public bool isMove = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //bergerak
        //kanan
        //kiri
        //tidak bergerak
        if (isMove == true)
        {
            //bergerak
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
        else
        {
            //tidak bergerak
            gameObject.transform.Translate(0, 0, 0);
        }
    }
}
