using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using TMPro;


public class codeEvent : UnityEvent <bool> {};

public class kod : MonoBehaviour
{
    public UnityEvent codeEvent; 
    private string code;
    [SerializeField] private TextMeshProUGUI tekst;
    [SerializeField] private Button button1;
    [SerializeField] private Button button2;
    [SerializeField] private Button button3;
    [SerializeField] private Button button4;
    [SerializeField] private Button button5;
    [SerializeField] private Button button6;
    [SerializeField] private Button button7;
    [SerializeField] private Button button8;
    [SerializeField] private Button button9;

    private void Start()
    {
        button1.onClick.AddListener(b1pressed);
        button2.onClick.AddListener(b2pressed);
        button3.onClick.AddListener(b3pressed);
        button4.onClick.AddListener(b4pressed);
        button5.onClick.AddListener(b5pressed);
        button6.onClick.AddListener(b6pressed);
        button7.onClick.AddListener(b7pressed);
        button8.onClick.AddListener(b8pressed);
        button9.onClick.AddListener(b9pressed);
    }

    private void b1pressed() {
        code = code + '1';
    }


    private void b2pressed()
    {
        code = code + '2';
    }

    private void b3pressed()
    {
        code = code + '3';
    }
        private void b4pressed() {
        code = code + "4";
    }

    private void b5pressed()
    {
        code = code + "5";
    }

    private void b6pressed()
    {
        code = code + "6";
    }

    private void b7pressed()
    {
        code = code + "7";
    }

    private void b8pressed()
    {
        code = code + "8";
    }

    private void b9pressed()
    {
        code = code + "9";
    }



    void Update()
    {
        tekst.text = code;

        if (code == "3425") { 
            // dŸwiêk otwierania drzwi 
            codeEvent.Invoke();
        } else if (code.Length >= 4 )
        {
            // z³y kod dŸwiêk
            code = "";
        }
    }
   
}
