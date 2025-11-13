using UnityEngine;

public class pemainlompat : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float forceMultiplier = 3.0f;
    public bool isgrounded;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Lompat()
    {
        if (isgrounded)
        {
            Rigidbody2D rb = GetComponent<Rigidbody2D>();
            rb.AddForce(transform.up * forceMultiplier, ForceMode2D.Impulse);
        }
        else
        {
            Debug.Log("lagi lompat");
        }
        
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Lantai"))
        {
            isgrounded = true;
            Debug.Log("diLantai");
        }
    }
    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Lantai"))
        {
            isgrounded = false;
            Debug.Log("di udara");
        }
    }
}
