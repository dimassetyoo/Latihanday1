using System.Collections;
using TMPro;
using UnityEngine.UI;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float waktu;
    public TMP_Text TimerText;
    public bool WaktuBerjalan = true;
    public KeyCode StartCoroutineKey;
    public KeyCode StopCoroutineKey;
    public Coroutine HitungTimerCoroutine;
    public Image ProgressFill;
    public int Maximumwaktu;
    
    /* private void Start()
    {
        StartCoroutine(HitungTimer());
    } */
    private void Update()
    {
        if (Input.GetKeyDown(StartCoroutineKey))
        {
            if (HitungTimerCoroutine == null) 
            {
                HitungTimerCoroutine = StartCoroutine(HitungTimer());
            }
        }
        if (Input.GetKeyDown(StopCoroutineKey))
        { 
            if (HitungTimerCoroutine != null)
            {
                StopCoroutine(HitungTimerCoroutine);
                HitungTimerCoroutine = null;
            }
        }
    }
    IEnumerator HitungTimer()
    {
        while(WaktuBerjalan == true && waktu < Maximumwaktu)
        { waktu = waktu + 1;
            TimerText.text = waktu.ToString();
            ProgressFill.fillAmount = waktu / Maximumwaktu;
            yield return new WaitForSeconds(1);
        }
    }
}
