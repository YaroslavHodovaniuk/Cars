using TMPro;
using UnityEngine;

public class AdRewards : MonoBehaviour
{
  [SerializeField] private Shop _shop;
    public void RewardUser(int id)
    {
        switch (id)
          {
            case 0:
              _shop.playerBalance += 1000;
              break;
            default:
              break;
    }
  }
    private void SetRandomMoney()
    {
      UnityEngine.Random.Range(800, 2500);
    }
}
