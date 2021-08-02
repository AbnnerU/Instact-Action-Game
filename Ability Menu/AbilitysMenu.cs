using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class AbilitysMenu : MonoBehaviour
{


    [SerializeField] private AbilityMenuButtons passiveButton;

    [SerializeField] private AbilityMenuButtons skill1Button;

    [SerializeField] private AbilityMenuButtons skill2Button;


    private Ability selectedPassive;

    private Ability selectedSkill1;

    private Ability selectedSkill2;

    private void Awake()
    {
        Ability[] curretAbilities = AbilityKitSave.LoadAllAbilities();

        selectedPassive = curretAbilities[0];

        selectedSkill1 = curretAbilities[1];

        selectedSkill2 = curretAbilities[2];

        DefineAbilitysOnButtons(selectedPassive, selectedSkill1, selectedSkill2);

        //print(selectedPassive);

        //print(selectedSkill1);

        //print(selectedSkill2);
    }

    public void SelectedPassive(Ability ability)
    {
        selectedPassive = ability;
    }

    public void SelectedSkill1(Ability ability)
    {
        selectedSkill1 = ability;
    }

    public void SelectedSkill2(Ability ability)
    {
        selectedSkill2 = ability;
    }

    public void BackToMenu()
    {
        AbilityKitSave.SavePassive(selectedPassive);

        AbilityKitSave.SaveSkill1(selectedSkill1);

        AbilityKitSave.SaveSkill2(selectedSkill2);

        SceneManager.LoadScene("Menu");
    }


    private void DefineAbilitysOnButtons(Ability passive, Ability skill1 , Ability skill2)
    {
        //print(passive);
        //print(skill1);
        //print(skill2);

        passiveButton.ChangeAbility(passive);

        skill1Button.ChangeAbility(skill1);

        skill2Button.ChangeAbility(skill2);
    }

}


[Serializable]
public class AbilityProperties
{
    public string abilityName;
   

    public void SetValues(Ability kitPassive)
    {
        abilityName = kitPassive.name;
       
    }
}

