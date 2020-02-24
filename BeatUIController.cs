using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeatUIController : MonoBehaviour
{
    GameObject leftUI;
    GameObject rightUI;
    public int beatsAtATime = 4;
    public int speed = 10;
    // Start is called before the first frame update
    void Start()
    {
        this.leftUI = GameObject.FindGameObjectWithTag("LeftBoundry");
        this.rightUI = GameObject.FindGameObjectWithTag("RightBoundry");
        this.transform.position = this.rightUI.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float dist = this.rightUI.transform.position.x - this.leftUI.transform.position.x;
        this.transform.position = new Vector3(this.transform.position.x - Time.deltaTime * (dist / this.beatsAtATime), this.transform.position.y, this.transform.position.z);
        if(this.transform.position.x < this.leftUI.transform.position.x)
        {
            Destroy(gameObject);
        }
    }
}
