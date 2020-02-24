using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileController : MonoBehaviour
{
    GameObject player;
    GameObject enemy;
    private bool fired = false;
    public float speed = 5;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<SpriteRenderer>().enabled = false;
        this.player = GameObject.FindGameObjectWithTag("Player");
        this.enemy = GameObject.FindGameObjectWithTag("Enemy");
        this.transform.position = this.player.transform.position;
        this.fired = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (this.fired)
        {
            if (this.transform.position.x < this.enemy.transform.position.x)
            {
                this.transform.position = new Vector3(this.transform.position.x + Time.deltaTime * this.speed, this.transform.position.y, this.transform.position.z);
            }
            else
            {
                // do animation or something
                this.fired = false;
                gameObject.GetComponent<SpriteRenderer>().enabled = false;
            }
        }
        else
        {
            //if (Input.GetKeyDown(KeyCode.Space))
            //{
            //    this.fired = true;
            //    gameObject.GetComponent<SpriteRenderer>().enabled = true;
            //}
        }
    }

    public void DoAttack(AttackTypes type)
    {
        if(type == AttackTypes.STANDARD && !this.fired)
        {
            gameObject.GetComponent<SpriteRenderer>().enabled = true;
            this.transform.position = this.player.transform.position;
            this.fired = true;
        }
    }
}
