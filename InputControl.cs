using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MidiJack;

public class InputControl : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (MidiMaster.GetKeyDown(4))
        {
            BroadcastMessage("GotInput", Inputs.FIRE);
        }
    }

    void GotInput(Inputs doSomething)
    {
        switch (doSomething)
        {
            case Inputs.FIRE:
                //do fire
                break;
        }
    }
}
