using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Advertisements;

public class MenuSc : MonoBehaviour
{

    public bool TestMode = true;

    public string AndroidID = "5291151";
    public string IOSID = "5291150";

    private string RewardedID = "Rewarded_Android";
    private string BannerID = "Interstitial_Android";
    private string InterstitialID = "Banner_Android";






    IEnumerator ShowBannerWhenReady()
    {
        while (!Advertisement.IsReady(BannerID))
        {
            yield return new WaitForSeconds(0.5f);
        }
        Advertisement.Banner.SetPosition(BannerPosition.BOTTOM_CENTER);
        Advertisement.Banner.Show(BannerID);
    }


    public Text Score;
    public void startButton()
    {
        SceneManager.LoadScene(1);
    }
    // Start is called before the first frame update
    void Start()
    {
#if UNITY_ANDROID
        Advertisement.Initialize(AndroidID, TestMode);
#else
        Advertisement.Initialize(IOSID, TestMode);
#endif

        StartCoroutine(ShowBannerWhenReady());
        Score.text = PlayerPrefs.GetInt("hightScore").ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
