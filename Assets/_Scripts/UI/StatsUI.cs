using TMPro;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class StatsUI : Singleton<StatsUI>
{
     [SerializeField] private TMP_Text _maxSpeed;
     [SerializeField] private TMP_Text _moneyBoost;
     [SerializeField] private Slider _maxSpeedSlider;
     [SerializeField] private Slider _moneyBoostSlider;

     public void UpdateStats(float maxSpeed, float moneyBoost)
     {
          _maxSpeedSlider.value = maxSpeed / 300;
          _moneyBoostSlider.value = moneyBoost / 10;
          _maxSpeed.text = maxSpeed.ToString();
          _moneyBoost.text = moneyBoost.ToString();
     }
}
