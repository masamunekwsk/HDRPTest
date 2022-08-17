using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class BallFall : MonoBehaviour
{
    public GameObject ball;
    
    //BallDropをインスタンス化して保持
    public static BallFall instance;

    
 
    //BallDropインスタンスがなければ、このBallDropをインスタンスとする
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }

    }
 
    public void BallAppear()
    {
        Instantiate(ball, new Vector3(2, 5, 0), Quaternion.identity);
    }
}