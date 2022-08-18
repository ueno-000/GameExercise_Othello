using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum PieceColor
{
    black = 1,
    white = -1
}

public class Piece : MonoBehaviour
{
    private Image _piece;

    [SerializeField] public PieceColor piececolor = PieceColor.black;

    // Start is called before the first frame update
    private void Start()
    {
        _piece = this.transform.GetChild(0).GetComponent<Image>();
    }

    // Update is called once per frame
    private void Update()
    {
        
    }

    public void ChangeColor(int id)
    {
        switch (piececolor)
        {
            case (PieceColor)1:
                break;
            case (PieceColor)(-1):
                break;
        }
    }
}
