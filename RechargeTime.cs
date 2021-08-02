using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
public class RechargeTime : MonoBehaviour
{
    [SerializeField]private float skillRechargeTime;

    public event Action<float> OnSkillRecharge;

    private Button button;

    private void Start()
    {
        button = GetComponent<Button>();
    }

    public void StartRecharge()
    {        

        OnSkillRecharge?.Invoke(skillRechargeTime);

        button.interactable = false;

        StartCoroutine(RechageCount(skillRechargeTime));
    }

    public void SetRechargeTime(float value)
    {
        skillRechargeTime = value;
    }

    IEnumerator RechageCount(float time)
    {
        yield return new WaitForSeconds(time);

        button.interactable = true;

        StopCoroutine(RechageCount(time));
    }
}
