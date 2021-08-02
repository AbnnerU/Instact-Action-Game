
using UnityEngine;
using UnityEngine.UI;


public class RechargeEffect : MonoBehaviour
{
    [SerializeField] private GameObject rechargeObject;

    [SerializeField] private Slider imageSlider;

    [SerializeField] private Text timerText;

    [SerializeField] private Image gray;

    private RechargeTime rechargeTime;

    private bool startRecharge;

    private float currentMaxValue;

    private void Start()
    {
        gray.enabled = false;

        timerText.enabled = false;

        rechargeObject.SetActive(false);

        rechargeTime = GetComponent<RechargeTime>();

        rechargeTime.OnSkillRecharge += RechargeTime_OnSkillRecharge;
    }

    private void RechargeTime_OnSkillRecharge(float rechargeValue)
    {
        //print("Recharge");
        gray.enabled = true;

        timerText.enabled = true;

        timerText.text = rechargeValue.ToString();

        rechargeObject.SetActive(true); 

        imageSlider.maxValue = rechargeValue;

        imageSlider.value = 0;

        currentMaxValue = rechargeValue;

        startRecharge = true;
    }

    private void Update()
    {
        if (startRecharge == false)
        {
            return;
        }

        imageSlider.value += Time.deltaTime;

        timerText.text = (int)(currentMaxValue - imageSlider.value)+"";

        if (imageSlider.value >= currentMaxValue)
        {
            gray.enabled = false;

            timerText.enabled = false;

            rechargeObject.SetActive(false);

            startRecharge = false;
        }

    }
}
