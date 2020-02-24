using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    HashSet<Inputs> elements;
    // Start is called before the first frame update
    void Start()
    {
        this.elements = new HashSet<Inputs>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void GotInput(Inputs element)
    {
        this.elements.Add(element);
        if (this.elements.Contains(Inputs.ATTACK))
        {
            AttackTypes type = this.GetAttackType();
            ComputerInput.SendToAll<AttackTypes>("DoAttack", type);
            this.elements = new HashSet<Inputs>();
        }
    }

    // Would check for combos based on what elements were selected
    AttackTypes GetAttackType()
    {
        if (this.elements.Count > 1)
        {
            return AttackTypes.STANDARD;
        }
        else
        {
            return AttackTypes.NO;
        }
    }
}
