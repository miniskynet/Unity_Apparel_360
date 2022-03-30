using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SendEmail : MonoBehaviour
{
    public Button submit;
    public GameObject model;
    public InputField receiver;

    private void Start()
    {
        submit.onClick.AddListener(delegate
        {
            string subject = "Order on " + DateTime.Now;
            int childCount = model.transform.childCount;
            String[] items = new String[childCount];
            String body="";
            for (int i = 0; i < childCount; i++)
            {
                items[i] = model.transform.GetChild(i).name;
            }

            String[] material = model.GetComponent<Renderer>().material.name.Split(' ');
            body += material[0] + " | ";
            body += model.GetComponent<Renderer>().material.color + " | ";
            HashSet<String> newList = new HashSet<String>(items);
            foreach (String item in newList)
            {
                String[] component = item.Split('(');
                body += component[0] + " | ";
            }
            Application.OpenURL("mailto:" + receiver.text + "?subject=" + subject + "&body=" + body);
        });
    }


}
