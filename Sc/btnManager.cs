using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Advertisements;

public class btnManager : MonoBehaviour
{
    public bool TestMode = true;

    public string AndroidID = "5291151";
    public string IOSID = "5291150";

    private string RewardedID = "Rewarded_Android";
    private string BannerID = "Interstitial_Android";
    private string InterstitialID = "Banner_Android";


    void Start()
    {
#if UNITY_ANDROID
        Advertisement.Initialize(AndroidID, TestMode);
#else
        Advertisement.Initialize(IOSID, TestMode);
#endif

        StartCoroutine(ShowBannerWhenReady());
    }

    public Text scoreTxt;
    int scr = 0;
    public Button b1,b2,b3,b4,b5,b6,b7,b8,b9,b10,b11,b12,b13,b14,b15,b16;

    public GameObject gameOverPnl;
    int b = 0;



    IEnumerator ShowBannerWhenReady()
    {
        while (!Advertisement.IsReady(BannerID))
        {
            yield return new WaitForSeconds(0.5f);
        }
        Advertisement.Banner.SetPosition(BannerPosition.BOTTOM_CENTER);
        Advertisement.Banner.Show(BannerID);
    }


    public void gameOverController(Button a)
    {
        
        if (a.GetComponent<Image>().color != Color.red && b>0)
        {
            b = 0;
            if (scr > PlayerPrefs.GetInt("hightScore"))
            {
                PlayerPrefs.SetInt("hightScore", scr);
            }
            SceneManager.LoadScene(0);
            
            
        }
        else
        {
            a.GetComponent<Image>().color = Color.white;
            b++;
            scr++;
            scoreTxt.text = scr.ToString();
        }
    }

    public void Clickers(int btn)
    {
        switch (btn)
        {
            case 1:
                hangiBtn(rndm(btn));
                gameOverController(b1);
                break;
            case 2:
                hangiBtn(rndm(btn));
                gameOverController(b2);
                break;
            case 3:
                hangiBtn(rndm(btn));
                gameOverController(b3);
                break;
            case 4:
                hangiBtn(rndm(btn));
                gameOverController(b4);
                break;
            case 5:
                hangiBtn(rndm(btn));
                gameOverController(b5);
                break;
            case 6:
                hangiBtn(rndm(btn));
                gameOverController(b6);
                break;
            case 7:
                hangiBtn(rndm(btn));
                gameOverController(b7);
                break;
            case 8:
                hangiBtn(rndm(btn));
                gameOverController(b8);
                break;
            case 9:
                hangiBtn(rndm(btn));
                gameOverController(b9);
                break;
            case 10:
                hangiBtn(rndm(btn));
                gameOverController(b10);
                break;
            case 11:
                hangiBtn(rndm(btn));
                gameOverController(b11);
                break;
            case 12:
                hangiBtn(rndm(btn));
                gameOverController(b12);
                break;
            case 13:
                hangiBtn(rndm(btn));
                gameOverController(b13);
                break;
            case 14:
                hangiBtn(rndm(btn));
                gameOverController(b14);
                break;
            case 15:
                hangiBtn(rndm(btn));
                gameOverController(b15);
                break;
            case 16:
                hangiBtn(rndm(btn));
                gameOverController(b16);
                break;

            default:
                break;
        }
    }
    public int rndm(int rs)
    {
        int rndom;
        rndom = Random.Range(1, 16);
        do
        {
            rndom = Random.Range(1, 16);
        } while (rndom==rs);
        return rndom;
    }

    public void hangiBtn(int deger)
    {
        switch (deger)
        {
            case 1:
                delayRed(b1);
                break;
            case 2:
                delayRed(b2);
                break;
            case 3:
                delayRed(b3);
                break;
            case 4:
                delayRed(b4);
                break;
            case 5:
                delayRed(b5);
                break;
            case 6:
                delayRed(b6);
                break;
            case 7:
                delayRed(b7);
                break;
            case 8:
                delayRed(b8);
                break;
            case 9:
                delayRed(b9);
                break;
            case 10:
                delayRed(b10);
                break;
            case 11:
                delayRed(b11);
                break;
            case 12:
                delayRed(b12);
                break;
            case 13:
                delayRed(b13);
                break;
            case 14:
                delayRed(b14);
                break;
            case 15:
                delayRed(b15);
                break;
            case 16:
                delayRed(b16);
                break;
            default:

                break;
        }
    }

    public void delayRed(Button a)
    {
        a.GetComponent<Image>().color = Color.red;
        StartCoroutine(ReplayWhite(a));
    }
    IEnumerator ReplayWhite(Button a)
    {
        yield return new WaitForSeconds(1f);
        a.GetComponent<Image>().color = Color.white;
    }
    /*public void repeatBtn()
    {
        SceneManager.LoadScene(0);
        b = 0;
    }*/

   
    

    private void Update()
    {
        if (b>0)
        {
            if (b1.GetComponent<Image>().color == Color.white &&
            b2.GetComponent<Image>().color == Color.white &&
            b3.GetComponent<Image>().color == Color.white &&
            b4.GetComponent<Image>().color == Color.white &&
            b5.GetComponent<Image>().color == Color.white &&
            b6.GetComponent<Image>().color == Color.white &&
            b7.GetComponent<Image>().color == Color.white &&
            b8.GetComponent<Image>().color == Color.white &&
            b9.GetComponent<Image>().color == Color.white &&
            b10.GetComponent<Image>().color == Color.white &&
            b11.GetComponent<Image>().color == Color.white &&
            b12.GetComponent<Image>().color == Color.white &&
            b13.GetComponent<Image>().color == Color.white &&
            b14.GetComponent<Image>().color == Color.white &&
            b15.GetComponent<Image>().color == Color.white &&
            b16.GetComponent<Image>().color == Color.white)
            {
                if (scr > PlayerPrefs.GetInt("hightScore"))
                {
                    PlayerPrefs.SetInt("hightScore", scr);
                }
                SceneManager.LoadScene(0);
            }
        }
        
    }





}
