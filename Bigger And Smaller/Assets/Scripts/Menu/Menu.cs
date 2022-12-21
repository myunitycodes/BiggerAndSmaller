using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    
    [SerializeField] GameObject levelLock1;
    [SerializeField] GameObject levelLock2;
    [SerializeField] GameObject levelLock3;
    [SerializeField] GameObject levelLock4;
    [SerializeField] GameObject levelLock5;

    [SerializeField] GameObject btnLevelLock1;
    [SerializeField] GameObject btnLevelLock2;
    [SerializeField] GameObject btnLevelLock3;
    [SerializeField] GameObject btnLevelLock4;
    [SerializeField] GameObject btnLevelLock5;

    TMPro.TextMeshProUGUI gemNumberText;
    

    private void Start()
    {
        StartPlayerPrefs();
    }












    void StartPlayerPrefs()
    {
        if (PlayerPrefs.HasKey("GemNumber")) gemNumberText.text = PlayerPrefs.GetInt("GemNumber").ToString();
        // if (PlayerPrefs.HasKey("Level1")) levelLock1.SetActive(PlayerPrefs.GetInt("Level1")==1);
        if (PlayerPrefs.HasKey("Level2")) levelLock2.SetActive(PlayerPrefs.GetInt("Level2") == 1);
        if (PlayerPrefs.HasKey("Level3")) levelLock3.SetActive(PlayerPrefs.GetInt("Level3") == 1);
        if (PlayerPrefs.HasKey("Level4")) levelLock4.SetActive(PlayerPrefs.GetInt("Level4") == 1);
        if (PlayerPrefs.HasKey("Level5")) levelLock5.SetActive(PlayerPrefs.GetInt("Level5") == 1);


        //  if (PlayerPrefs.HasKey("BtnLevel2")) btnLevelLock1.GetComponent<Button>().interactable=(PlayerPrefs.GetInt("BtnLevel2") ==1);
        if (PlayerPrefs.HasKey("BtnLevel2")) btnLevelLock2.GetComponent<Button>().interactable = (PlayerPrefs.GetInt("BtnLevel2") == 1);
        if (PlayerPrefs.HasKey("BtnLevel3")) btnLevelLock3.GetComponent<Button>().interactable = (PlayerPrefs.GetInt("BtnLevel3") == 1);
        if (PlayerPrefs.HasKey("BtnLevel4")) btnLevelLock4.GetComponent<Button>().interactable = (PlayerPrefs.GetInt("BtnLevel4") == 1);
        if (PlayerPrefs.HasKey("BtnLevel5")) btnLevelLock5.GetComponent<Button>().interactable = (PlayerPrefs.GetInt("BtnLevel5") == 1);




    }


    AsyncOperation asyncLoad;
    IEnumerator CoLoadAsyncScene(string sceneName)
    {
        asyncLoad = SceneManager.LoadSceneAsync(sceneName, LoadSceneMode.Single);

        asyncLoad.allowSceneActivation = false;

        yield return new WaitUntil(() => asyncLoad.progress >= 0.9f);

        asyncLoad.allowSceneActivation = true;

    }

    public void LoadLevel1()
    {
        StartCoroutine(CoLoadAsyncScene("Scenes/Level1"));
    }
    public void LoadLevel2()
    {
        StartCoroutine(CoLoadAsyncScene("Scenes/Level2"));
    }
    public void LoadLevel3()
    {
        StartCoroutine(CoLoadAsyncScene("Scenes/Level3"));
    }
    public void LoadLevel4()
    {
        StartCoroutine(CoLoadAsyncScene("Scenes/Level4"));
    }
    public void LoadLevel5()
    {
        StartCoroutine(CoLoadAsyncScene("Scenes/Level5"));
    }





    //Singleton ayarlari
    private static Menu instance;
    public static Menu Instance { get { return instance; } }
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject); //?ste?e ba?li Sahneler arasi geçi?te bu classin kapanmamasi icin } 

        }
        else { Destroy(this); }


    }






}
