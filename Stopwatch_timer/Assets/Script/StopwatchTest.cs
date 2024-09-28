using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using TMPro;
using UnityEngine;

public class StopwatchTest : MonoBehaviour
{
    [Header("Stopwatch Text")] [SerializeField]
    public TextMeshProUGUI isrunning;
    public TextMeshProUGUI elapsedText;
    public TextMeshProUGUI elapsedMillisecondsText;
    public TextMeshProUGUI elapsedTicksText;

    [Header("Stopwatch Date/Time Text")]
    public TextMeshProUGUI days;
    public TextMeshProUGUI totaldays;
    public TextMeshProUGUI hours;
    public TextMeshProUGUI totalhours;
    public TextMeshProUGUI minutes;
    public TextMeshProUGUI totalminutes;
    public TextMeshProUGUI seconds;
    public TextMeshProUGUI totalseconds;
    public TextMeshProUGUI equalsText;
    
    
    
    private Stopwatch sw;
    
    // Start is called before the first frame update
    void Start()
    {
        sw = new Stopwatch();
    }

    // Update is called once per frame
    void Update()
    {
        isrunning.text = "Isrunning : " + sw.IsRunning.ToString();
        elapsedText.text = sw.Elapsed.ToString();
        elapsedMillisecondsText.text = sw.ElapsedMilliseconds.ToString();
        elapsedTicksText.text = sw.ElapsedTicks.ToString();
        days.text = "Days(일만 추출) : " + sw.Elapsed.Days; //string과 더하면 int가 string으로 변환되어 toString이 필요없다.
        totaldays.text = "TotalDays(시간을 day기준 환산) : \n" + sw.Elapsed.TotalDays;
        hours.text = "Hours(시간만) : " + sw.Elapsed.Hours.ToString();
        totalhours.text = "TotalHours(Hour기준으로 환산) : \n" + sw.Elapsed.TotalHours;
        minutes.text = "Minutes(분만) : " + sw.Elapsed.Minutes;
        totalminutes.text = "TotalMinutes(minutes기준으로 환산) : \n" + sw.Elapsed.TotalMinutes;
        seconds.text = "Seconds(초만) : " + sw.Elapsed.Seconds;
        totalseconds.text = "TotalSeconds(초기준 환산) : " + sw.Elapsed.TotalSeconds;
        equalsText.text = "5초일 때 : " + sw.Elapsed.Seconds.Equals(5);
        // sw.Elapsed.TotalDays;


    }
    

    public void OnStartClick()
    {
        sw.Start();
    }

    public void OnStopClick()
    {
        sw.Stop();
    }

    public void OnRestartClick()
    {
        sw.Restart();
    }

    public void OnResetClick()
    {
        sw.Reset();
    }
}
