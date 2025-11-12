using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Databasegambar", menuName = "Scriptable Objects/Database Gambar")]
public class Databasegambar : ScriptableObject
{
    public List<Sprite> ListGambar = new List<Sprite>();
}
