using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public class Unit : MonoBehaviour
{
    private float hp;
    private float connectDamage;

    public float Hp { get => hp; set => hp = value; }
    public float ConnectDamage { get => connectDamage; set => connectDamage = value; }

    public void TakeDamage(float damage)
    {
        Hp = (Hp - damage);
    }
}

