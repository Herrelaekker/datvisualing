using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class Stat
{

    [SerializeField]
    private HUD bar;

    [SerializeField]
    private float maxVal;

    [SerializeField]
    private float curVal;

    public float CurVal
    {
        get
        {
            return curVal;
        }

        set
        {
            bar.Value = curVal;
            this.curVal = Mathf.Clamp(value, 0, MaxVal);
        }
    }

    public float MaxVal
    {
        get
        {
            return maxVal;
        }
        set
        {
            this.maxVal = value;
            bar.maxValue = maxVal;
        }
    }

    public void Initialize()
    {
        this.MaxVal = maxVal;
        this.CurVal = curVal;
    }

}
