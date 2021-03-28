using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float RotateSpeed;
    public Transform Coin;
    private void Update()
    {
        Coin.transform.Rotate(0,Time.deltaTime*RotateSpeed,0);
    }
}
