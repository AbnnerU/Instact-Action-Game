using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class AbilityMenuButtons : MonoBehaviour
{
    [SerializeField] private Text descriptionText;

    [SerializeField] private Text nameText;

    [SerializeField] private Text rechargeText; 

    [SerializeField] private Image iconImage;  

    private Ability currentAbility;

    private void Start()
    {
        //descriptionText = GameObject.FindGameObjectWithTag("Description").GetComponent<Text>();

    }

    public void ChangeAbility(Ability newAbility)
    {
        print(newAbility);
        iconImage.sprite = newAbility.abilityIcon;

        currentAbility = newAbility;

        ChangeDescripition();
    }

    public void ChangeDescripition()
    {
        //print(currentAbility.description);
        nameText.text = currentAbility.abilityName;
        descriptionText.text = currentAbility.description;
        rechargeText.text = currentAbility.RechargeTime.ToString();
    }
}
