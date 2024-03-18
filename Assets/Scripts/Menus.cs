using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Menus : MonoBehaviour
{

    public TMP_Text record1;
    public TMP_Text record2;
    public TMP_Text record3;
    public TMP_Text record4;
    public TMP_Text record5;
    public TMP_Text record6;
    public TMP_Text record7;
    public TMP_Text record8;



    public void Salir()
    {
        Application.Quit();
    }
    public void Ira(string nombre)
    {
        SceneManager.LoadScene(nombre);
    }
    public void Start()
    {
        Records();
    }

    public void Records()
    {
        record1.text = PlayerPrefs.GetInt("record" + 1, 0).ToString();
        record2.text = PlayerPrefs.GetInt("record" + 2, 0).ToString();
        record3.text = PlayerPrefs.GetInt("record" + 3, 0).ToString();
        record4.text = PlayerPrefs.GetInt("record" + 4, 0).ToString();
        record5.text = PlayerPrefs.GetInt("record" + 5, 0).ToString();
        record6.text = PlayerPrefs.GetInt("record" + 6, 0).ToString();
        record7.text = PlayerPrefs.GetInt("record" + 7, 0).ToString();
        record8.text = PlayerPrefs.GetInt("record" + 8, 0).ToString();

    }

    public void BorrarRecord()
    {
        PlayerPrefs.DeleteAll();
    }
}
