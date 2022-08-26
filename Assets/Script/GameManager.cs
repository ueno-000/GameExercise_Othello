using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //ターン表示のオブジェクト
    [SerializeField] private GameObject _trunImageBlack;
    [SerializeField] private GameObject _trunImageWhite;
    void Start()
    {
        _trunImageBlack.gameObject.SetActive(true);
        _trunImageWhite.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
