using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class losezone : MonoBehaviour
{
    public bool onetm;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && !onetm)
        {
            onetm = true;
            StartCoroutine(losegm());
        }
    }

    IEnumerator losegm()
    {
        FindObjectOfType<RCC_CarControllerV3>().gameObject.GetComponent<RCC_CarControllerV3>().SetEngine(false);
        SoundManager.instance.Play("fail");
        GoogleAdsSystem.Instance.ShowInterstitialAd();
        yield return new WaitForSeconds(1f);
        UiManager.instance.losepanel.SetActive(true);
    }
}
