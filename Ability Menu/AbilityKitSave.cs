using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


public static class AbilityKitSave
{
    #region Passive
    public static void SavePassive(Ability parametres)
    {
        BinaryFormatter formatter = new BinaryFormatter();

        string path = Application.persistentDataPath + "playerPassive.abilitys";

        //Debug.Log(path);

        FileStream stream = new FileStream(path, FileMode.Create);

        AbilityProperties abilityKit = new AbilityProperties();

        abilityKit.SetValues(parametres);

        formatter.Serialize(stream, abilityKit);

        stream.Close();
        
    }

    public static AbilityProperties LoadPassive()
    {
        string path = Application.persistentDataPath + "playerPassive.abilitys";

        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();

            FileStream stream = new FileStream(path, FileMode.Open);

            AbilityProperties abilityProperties = formatter.Deserialize(stream) as AbilityProperties;

            stream.Close();

            return abilityProperties;

        }
        else
        {
            return null;
        }

    }

    #endregion


    #region Skill1
    public static void SaveSkill1(Ability parametres)
    {
        BinaryFormatter formatter = new BinaryFormatter();

        string path = Application.persistentDataPath + "playerSkill1.abilitys";

        //Debug.Log(path);

        FileStream stream = new FileStream(path, FileMode.Create);

        AbilityProperties abilityKit = new AbilityProperties();

        abilityKit.SetValues(parametres);

        formatter.Serialize(stream, abilityKit);

        stream.Close();

    }

    public static AbilityProperties LoadSkill1()
    {
        string path = Application.persistentDataPath + "playerSkill1.abilitys";

        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();

            FileStream stream = new FileStream(path, FileMode.Open);

            AbilityProperties abilityProperties = formatter.Deserialize(stream) as AbilityProperties;

            stream.Close();

            return abilityProperties;

        }
        else
        {
            return null;
        }

    }
    #endregion


    #region Skill2
    public static void SaveSkill2(Ability parametres)
    {
        BinaryFormatter formatter = new BinaryFormatter();

        string path = Application.persistentDataPath + "playerSkill2.abilitys";

        //Debug.Log(path);

        FileStream stream = new FileStream(path, FileMode.Create);

        AbilityProperties abilityKit = new AbilityProperties();

        abilityKit.SetValues(parametres);

        formatter.Serialize(stream, abilityKit);

        stream.Close();

    }

    public static AbilityProperties LoadSkill2()
    {
        string path = Application.persistentDataPath + "playerSkill2.abilitys";

        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();

            FileStream stream = new FileStream(path, FileMode.Open);

            AbilityProperties abilityProperties = formatter.Deserialize(stream) as AbilityProperties;

            stream.Close();

            return abilityProperties;

        }
        else
        {
            return null;
        }

    }
    #endregion

    public static Ability[] LoadAllAbilities()
    {
        Ability[] allAbilities = new Ability[3];

        allAbilities[0] = Resources.Load<Ability>("Scriptable Objects/Abilitys/Passives/" + AbilityKitSave.LoadPassive().abilityName);

        allAbilities[1] = Resources.Load<Ability>("Scriptable Objects/Abilitys/" + AbilityKitSave.LoadSkill1().abilityName);

        allAbilities[2] = Resources.Load<Ability>("Scriptable Objects/Abilitys/" + AbilityKitSave.LoadSkill2().abilityName);

        Debug.Log(allAbilities[0]);

        return allAbilities;
    }
}


