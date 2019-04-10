using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CounterHandler : MonoBehaviour {

    public Text CounterText;

    bool IsCounting = false;
    float EndTime;
    RowHandler RowManagement;
    MenuHandler MenuManagement;

    private void Start()
    {
        RowManagement = GetComponent<RowHandler>();
        
    }

    public void StartCounting(int From = 3)
    {
        EndTime = Time.time + From;
        CounterText.gameObject.SetActive(true);
        CounterText.text = From.ToString();
        IsCounting = true;

    }

    private void Update()
    {
        if (IsCounting)
        {
            int TimeLeft = Convert.ToInt32(EndTime - Time.time);
            if(TimeLeft < 0)
            {
                TimeLeft = 0;
                RowManagement.StartRowsMoving();
                CounterText.gameObject.SetActive(false);
                IsCounting = false;
            }
            CounterText.text = TimeLeft.ToString();
        }
    }


}
