using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum PieceColor
{
    black = 1,
    white = -1,

    none = 0,
}

public class Piece : MonoBehaviour
{
    [SerializeField] private GameObject _piece;

    private Color _thisColor;
    //private int id = 0;

    [SerializeField] public PieceColor piececolor = PieceColor.none;

    // Start is called before the first frame update
    private void Start()
    {
        _thisColor = GetComponent<Image>().color;

        piececolor = PieceColor.none;

        OnPieceStateChange();

    }

    public void OnPieceStateChange()
    {
        switch (piececolor)
        {
            case PieceColor.black:
                _piece.GetComponent<Image>().color = Color.black;
                break;
            case PieceColor.white:
                _piece.GetComponent<Image>().color = Color.white;
                break;
            case PieceColor.none:
                _piece.GetComponent<Image>().color = new Color(0f, 0f, 0f, 0f);
                break;
        }
    }

    private void OnValidate()
    {



    }
    // Update is called once per frame
    private void Update()
    {
        OnPieceStateChange();  
    }


}
