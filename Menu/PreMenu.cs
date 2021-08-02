using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PreMenu : MonoBehaviour
{
    [SerializeField] private Ability defaltPassive;

    [SerializeField] private Ability defaltSkill1;

    [SerializeField] private Ability defaltSkill2;

    private AbilityProperties properties;

    // Start is called before the first frame update
    void Awake()
    {
        if (AbilityKitSave.LoadPassive() == null)
        {
            print("Carregar");
            AbilityKitSave.SavePassive(defaltPassive);

            AbilityKitSave.SaveSkill1(defaltSkill1);

            AbilityKitSave.SaveSkill2(defaltSkill2);
        }

        SceneManager.LoadScene("Menu");
    }

  
}
