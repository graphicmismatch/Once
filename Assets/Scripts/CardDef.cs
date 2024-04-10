using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public struct Ability {
    public float burnChance;
    public int burnTurns;
    public float poisonChance;
    public int poisonTurns;
    public int heal;
    public int damage;

}

[CreateAssetMenu(fileName = "Card", menuName = "ScriptableObjects/Card", order = 1)]
public class CardDef : ScriptableObject
{
    public string CardName;
    public bool canUntrap;
    public float lockpickChance;
    public int baseHealth;
    public float evasion;
    public int baseAttack;
    public float critChance;
    public Ability ability;
    [Multiline]
    public string description;
    public Sprite mugShot;
    public Sprite cardVariant;
}
