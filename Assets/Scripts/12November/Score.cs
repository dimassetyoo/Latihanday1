using UnityEngine;

public class score : MonoBehaviour
{
    // public int Score;
    //public void AddScore()
    //{
    //Score = Score + 1;
    //}
    public PendeteksiInput objectPendeteksiInput;
    public int Score;
    private void OnEnable()
    {
        // listen
        objectPendeteksiInput.inputEvent += AddScore;
    }
    public void AddScore()
    {
        Score = Score + 1;
    }
    private void OnDisable()
    {
      //unlisten
       objectPendeteksiInput.inputEvent -= AddScore;
    }
}
