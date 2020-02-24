using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeatController : MonoBehaviour
{
    public int BeatsPerMinute = 60;
    public int BeatsPerMeasure = 4;
    public GameObject beatPrefab;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("DoBeat", 0f, Convert.ToSingle(this.BeatsPerMinute) / 60);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void DoBeat()
    {
        GameObject.Instantiate(beatPrefab, this.transform);
    }
}
