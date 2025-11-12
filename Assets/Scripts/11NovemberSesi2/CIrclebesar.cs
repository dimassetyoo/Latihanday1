using System.Numerics;
using UnityEngine;

public class CIrclebesar : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.localScale += new UnityEngine.Vector3(1, 1, 1) * Time.deltaTime;
    }
}
