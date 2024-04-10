using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Card : MonoBehaviour
{
    [SerializeField]
    CardDef data;


    string CardName;
    bool canUntrap;
    float lockpickChance;
    float evasion;
    int baseHealth;
    int baseAttack;
    float critChance; 
    Ability ability;
    string cardDescription;
    Sprite mugShot;
    Sprite cardVariant;

    [SerializeField]
    int currentHealth;

    [SerializeField]
    int currentAttack;

    int level;

    [Header("Card")]
    [SerializeField]
    Image cardBG;
    [SerializeField]
    TMP_Text title;
    [SerializeField]
    Image mugshot;
    [SerializeField]
    TMP_Text description;
    [SerializeField]
    TMP_Text health;
    [SerializeField]
    TMP_Text damage;
    [SerializeField]
    TMP_Text levelDisp;

    [Header("Preview")]
    [SerializeField]
    Image pcardBG;
    [SerializeField]
    TMP_Text ptitle;
    [SerializeField]
    Image pmugshot;
    [SerializeField]
    TMP_Text pdescription;
    [SerializeField]
    TMP_Text phealth;
    [SerializeField]
    TMP_Text pdamage;
    [SerializeField]
    TMP_Text plevelDisp;


    // Start is called before the first frame update
    void Start()
    {
        init();
    }

    private void init()
    {
        CardName = data.CardName;
        canUntrap = data.canUntrap;
        lockpickChance = data.lockpickChance;
        baseHealth = data.baseHealth;
        baseAttack = data.baseAttack;
        currentHealth = baseHealth;
        currentAttack = baseAttack;
        critChance = data.critChance;
        ability = data.ability;
        cardDescription = data.description;
        mugShot = data.mugShot;
        cardVariant = data.cardVariant;
        level = 1;
        evasion = data.evasion;
        updateUI();
    }

    private void updateUI() {
        cardBG.sprite = cardVariant;
        title.text = CardName;
        mugshot.sprite = mugShot;
        description.text = cardDescription;
        health.text =  currentHealth+"";
        damage.text = currentAttack + "";
        levelDisp.text = level + "";

        pcardBG.sprite = cardVariant;
        ptitle.text = CardName;
        pmugshot.sprite = mugShot;
        pdescription.text = cardDescription;
        phealth.text = currentHealth + "";
        pdamage.text = currentAttack + "";
        plevelDisp.text = level + "";
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
