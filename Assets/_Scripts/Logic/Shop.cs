using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Shop : Singleton<Shop>
{

    public int playerBalance
    {
        get => PlayerPrefs.GetInt("PlayerBalance");
        set
        {
            PlayerPrefs.SetInt("PlayerBalance", value);
            RCC_CarSelectionExample.Instance.UpdateMoneyText(playerBalance);
        } }

    private Dictionary<int, int> _carPrices = new Dictionary<int, int>()
    {
        { 0, 2000 }, 
        { 1, 2000 }, 
        { 2, 25000 }, 
        { 3, 30000 }, 
        { 4, 22000 }, 
        { 5, 27000 },
        { 6, 28000 },
        { 7, 29000 },
        { 8, 30000 },
        { 9, 31000 },
        { 10, 32000 },
        { 11, 33000 },
        { 12, 34000 },
        { 13, 35000 },
    };
    
    private void Start()
    {
        // Загрузка баланса игрока из PlayerPrefs
        playerBalance = PlayerPrefs.GetInt("PlayerBalance", 100000); // Начальный баланс - 1000 монет
    }

    public void PurchaseCar(int index)
    {
        if (playerBalance >= _carPrices[index])
        {
            playerBalance -= _carPrices[index];
            PlayerPrefs.SetInt("PlayerBalance", playerBalance);
            PlayerPrefs.SetInt(index.ToString(), 1); // Сохранение покупки машины
            RCC_CarSelectionExample.Instance.UpdateMoneyText(playerBalance);
            RCC_CarSelectionExample.Instance.UpdateButton();
            Debug.Log($" purchased!");
        }
        else
        {
            Debug.Log("Not enough balance!");
        }
    }

    public bool CheckBoughtCar(int id)
    {
        if (PlayerPrefs.GetInt(id.ToString(), 0) == 1)
            return true;
        else
            return false;
    }
    
    

    public int GetPrice(int id)
    {
        return _carPrices[id];
    }

}
