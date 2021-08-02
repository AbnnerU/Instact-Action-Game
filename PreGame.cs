using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PreGame : MonoBehaviour
{
    [SerializeField] private AbilityInputManeger abilityInputManeger;
   
    [SerializeField] private RechargeTime skill1Recharge;

    [SerializeField] private RechargeTime skill2Recharge;

    [SerializeField] private Image passiveImage;

    [SerializeField] private Image skill1Image;

    [SerializeField] private Image skill2Image;

    private void Awake()
    {
        Ability[] allAbilities = AbilityKitSave.LoadAllAbilities();

        //Abilities buttons
        skill1Recharge.SetRechargeTime(allAbilities[1].RechargeTime);

        skill2Recharge.SetRechargeTime(allAbilities[2].RechargeTime);

        //Buttons Images

        passiveImage.sprite = allAbilities[0].abilityIcon;
        skill1Image.sprite = allAbilities[1].abilityIcon;
        skill2Image.sprite = allAbilities[2].abilityIcon;


        //Abilities Controller
        abilityInputManeger.SetAbilities(allAbilities[0], allAbilities[1], allAbilities[2]);

        abilityInputManeger.ConfigNewScripts();
    }
}
