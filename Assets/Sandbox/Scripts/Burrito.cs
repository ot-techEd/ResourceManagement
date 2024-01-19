using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Burrito : Item
{
    [SerializeField] private GameObject burritoWrap;
    public override void ShowItem()
    {
        burritoWrap.SetActive(true);
    }
}
