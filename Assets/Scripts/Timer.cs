using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Timer : MonoBehaviour
{
    [Header("Component")]
    public TextMeshProUGUI timerText;

    [Header("Timer settings")]
    public float currentTime;
    public bool countUp;

    [Header("Limit Settings")]
    public bool hasLimit;
    public float timerLimit;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentTime = countUp ? currentTime -= Time.deltaTime : currentTime += Time.deltaTime;

        if(hasLimit && ((countUp && currentTime <= timerLimit) || (!countUp && currentTime >= timerLimit)))
        {
            currentTime = timerLimit;
            setTimerText();
            timerText.color = Color.white;
            enabled = false;
        }

        setTimerText();
    }

    private void setTimerText()
    {
        timerText.text = currentTime.ToString("0.00");
    }
}
