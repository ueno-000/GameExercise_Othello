using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

  public enum color
{
    black = 1,
    white = -1
}

public class Piece : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static implicit operator Piece(GameObject v)
    {
        throw new NotImplementedException();
    }


}
