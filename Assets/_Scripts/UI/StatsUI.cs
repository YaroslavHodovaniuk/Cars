using TMPro;
using UnityEngine;

public class StatsUI : MonoBehaviour
{
     private TMP_Text _lvl;
     private TMP_Text _hp;

     public void UpdateStats(int lvl, int hp)
     {
          _lvl.text = lvl.ToString();
          _hp.text = hp.ToString();
     }
}
