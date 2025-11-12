using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using System;

public class PendeteksiInput : MonoBehaviour
{
    // public score scriptscore;   
    //private void Update()
    // {

    // if (Input.GetKeyDown(KeyCode.Space))
    //{
    //  scriptscore.AddScore();
    // }
    //}
    public Action inputEvent;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            inputEvent.Invoke();
        }
    }
}
