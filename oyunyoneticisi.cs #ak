using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class oyunyoneticisi : MonoBehaviour
{
    GameObject dc;//dönen çember
    GameObject ac;//ana çember
    public Animator an;//animatör
    public Text dcl;//dönen çember level
    public Text bir;
    public Text iki;
    public Text uc;
    public int kt;//kaç tane küçük çember olsun
    bool kontrol = true;
    void Start()
    {
        dc = GameObject.FindGameObjectWithTag("donencembertag");
        ac = GameObject.FindGameObjectWithTag("anacembertag");
        dcl.text = SceneManager.GetActiveScene().name;
    }
    
    public void kucukcembertext()
    {
        kt--;
        if (kt < 2)
        {
            bir.text = kt + "";
            iki.text = "";
            uc.text = "";
        }
        else if (kt < 3)
        {
            bir.text = kt + "";
            iki.text = (kt - 1) + "";
            uc.text = "";

        }
        else
        {

            bir.text = kt + "";
            iki.text = (kt - 1) + "";
            uc.text = (kt - 2) + "";
        }

        if (kt == 0)
        {
            StartCoroutine(yenilev());
        }
    }
    IEnumerator yenilev()
    {

        dc.GetComponent<donencemberkod>().enabled = false;
        ac.GetComponent<anacemberkod>().enabled = false;
        yield return new WaitForSeconds(1);
        
        if (kontrol)
        {
            an.SetTrigger("yenilevel");

            yield return new WaitForSeconds(2);

            SceneManager.LoadScene(int.Parse(SceneManager.GetActiveScene().name) + 1); //string bir değişkeni int yapma
        }
       
    }

    public void oyunbitti()
    {
        StartCoroutine(gameover());
    }

    IEnumerator gameover()
    {
        dc.GetComponent<donencemberkod>().enabled = false;
        ac.GetComponent<anacemberkod>().enabled = false;
        an.SetTrigger("oyunbitti");
        kontrol = false;

        yield return new WaitForSeconds(2);//2 sn bekleme
       
        SceneManager.LoadScene("anamen");
    }
}
