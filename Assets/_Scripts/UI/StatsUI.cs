using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class StatsUI : Singleton<StatsUI>
{
     [SerializeField] private TMP_Text _lvl;
     [SerializeField] private TMP_Text _hp;
     [SerializeField] private Slider _lvlSlider;
     [SerializeField] private Slider _hpSlider;

     public void UpdateStats(float lvl, float hp)
     {
          _lvlSlider.value = lvl / 5;
          _hpSlider.value = hp / 5000;
          _lvl.text = lvl.ToString();
          _hp.text = hp.ToString();
     }
}
