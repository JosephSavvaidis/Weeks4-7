using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class KitClock : MonoBehaviour
{
    public float timeAnHourTakes = 5;

    public float t;
    public int hour = 0;

    public float kitKat;
    public Transform minuteHand;

    public UnityEvent OnTheHour;

    Coroutine ClockisRunning;
    IEnumerator doOneHour;

    void Start()
    {
       ClockisRunning = StartCoroutine(MoveTheClock());
    }
    private IEnumerator MoveTheClock()
    {
        while (true)
        {
            //doOneHour = MovetheClockHandOneHour();
            yield return StartCoroutine(MoveTheClockHandOneHour());
        }
        
        
    }
    private IEnumerator MoveTheClockHandOneHour()
    {
        t = 0;
        while(t < timeAnHourTakes)
        {
            t += Time.deltaTime;
            minuteHand.Rotate(0, 0, -(360/timeAnHourTakes) * Time.deltaTime);
            minuteHand.Rotate(0, 0, -(30 / timeAnHourTakes) * Time.deltaTime);
            yield return null;
        }
        OnTheHour.Invoke();
       // yield return new WaitForSeconds(5);
    }
    public void StopTheClock()
    {
        if(ClockisRunning != null)
        {
            StopCoroutine(ClockisRunning);
        }
        if(doOneHour != null)
        {
            StopCoroutine(doOneHour);
        }
        
    }
}
