using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class CubeClick : MonoBehaviour
{
    void OnMouseDown()
    {
        //BallDropのBallAppearを実行
        BallFall.instance.BallAppear();
    }
}