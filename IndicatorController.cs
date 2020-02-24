using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IndicatorController : MonoBehaviour
{
    public Inputs element;
    private SpriteRenderer sr;
    // Start is called before the first frame update
    void Start()
    {
        this.sr = GetComponent<SpriteRenderer>();
        this.sr.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void GotInput(Inputs element)
    {
        if(this.element == element)
        {
            this.sr.enabled = true;
        }
    }

    public void DoAttack(AttackTypes type)
    {
        this.sr.enabled = false;
    }
}
