using UnityEngine;

public class KMG_CekInput : MonoBehaviour
{
    public GameObject _Square;
    public GameObject _UntukSpawn;
    public GameObject _TargetDestroy;
    public GameObject _Kotakberwarna;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Tombol spasi di tekan");
        }

        if (Input.GetKeyDown(KeyCode.O))
        {
            Debug.Log("Tombol O ditekan, object muncul");
            _Square.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            Debug.Log("Tombol P ditekan. object tersembunyi");
            _Square.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Tombol enter ditekan.");
            Instantiate(_UntukSpawn, new Vector3(Random.Range(-5, 5), Random.Range(-5, 5), 0), Quaternion.Euler(0, 0, 0));
        }
        if (Input.GetKeyDown(KeyCode.M))
        {
            GameObject hancurkan = GameObject.Find("Triangle(Clone)");
            Debug.Log("Tombol L ditekan.");
            Destroy(_TargetDestroy);
            Destroy(hancurkan);
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            /* SpriteRenderer _localSpriteRenderer = _Kotakberwarna.GetComponent<SpriteRenderer>();
            _localSpriteRenderer.color = Color.black; */
            SpriteRenderer _localSpriteRenderer = _Kotakberwarna.GetComponent<SpriteRenderer>();
            Color warnaAcak = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));
            _localSpriteRenderer.color = warnaAcak;
        }
    }
}
