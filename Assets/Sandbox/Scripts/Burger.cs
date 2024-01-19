using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Burger : Item
{
    [SerializeField] private Transform burgerBun;
    public override void ShowItem()
    {
        burgerBun.position = new Vector3(0, 1, 0);
    }
}
