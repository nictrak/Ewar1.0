using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Combat
{
    private int attack;
    private int defense;

    public Combat()
    {
        attack = 0;
        defense = 0;
    }

    Combat(int attack, int defense)
    {
        this.attack = attack;
        this.defense = defense;
    }

    public int Attack { get => attack; set => attack = value; }
    public int Defense { get => defense; set => defense = value; }

    public static Combat Add(Combat one, Combat two)
    {
        int newAttack = one.attack + two.attack;
        int newDefense = one.defense + two.defense;
        return new Combat(newAttack, newDefense);
    }
    public static Combat AddMultiple(params Combat[] combats)
    {
        Combat result = new Combat();
        if (combats.Length <= 0) return result;
        result = combats[0];
        for (int i = 1; i < combats.Length; i++)
        {
            result = Add(result, combats[i]);
        }
        return result;
    }
}
