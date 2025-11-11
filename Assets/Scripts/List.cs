using Unity.VisualScripting.ReorderableList.Element_Adder_Menu;
using UnityEngine;
using System;
using System.Collections.Generic;

public class List : MonoBehaviour
{
    [SerializeField]
    List<Player> ListPlayer = new List<Player>();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Player player = ListPlayer.Find(element => element.Level >= 15);
        Debug.Log(player.Name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
