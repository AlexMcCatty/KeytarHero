using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComputerInput : MonoBehaviour
{
    static GameObject[] objects;
    // Start is called before the first frame update
    void Start()
    {
        ComputerInput.objects = FindObjectsOfType<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            ComputerInput.SendToAll<Inputs>("GotInput", Inputs.FIRE);
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            ComputerInput.SendToAll<Inputs>("GotInput", Inputs.EARTH);
        }
        else if(Input.GetKeyDown(KeyCode.E))
        {
            ComputerInput.SendToAll<Inputs>("GotInput", Inputs.LIGHTNING);
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            ComputerInput.SendToAll<Inputs>("GotInput", Inputs.WATER);
        }
        else if(Input.GetKeyDown(KeyCode.Space))
        {
            ComputerInput.SendToAll<Inputs>("GotInput", Inputs.ATTACK);
        }
    }

    public static void SendToAll<T>(string func, T input)
    {
        for (int i = 0; i < ComputerInput.objects.Length; ++i)
        {
            if (ComputerInput.objects[i] != null)
            {
                ComputerInput.objects[i].SendMessage(func, input, SendMessageOptions.DontRequireReceiver);
            }
        }
    }
}
