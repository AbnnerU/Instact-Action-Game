using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AbilityMenuOptions : MonoBehaviour
{
    [SerializeField] private AbilityMenuButtons abilityButton;

    [SerializeField] private Ability abilityOption;

    private Image iconImage;

    // Start is called before the first frame update
    void Start()
    {

        iconImage = GetComponent<Image>();

        iconImage.sprite = abilityOption.abilityIcon;
    }

    public void ChangeAbilityOnButton()
    {
        abilityButton.ChangeAbility(abilityOption);
    }

   
}
