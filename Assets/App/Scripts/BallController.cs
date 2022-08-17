using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
        private Vector3 pos;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        pos = this.transform.position;
        Debug.Log(pos.y);
        if(pos.y < -1.0)
        {
            Destroy(this.gameObject);
        }
    }
}
