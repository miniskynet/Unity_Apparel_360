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
            //assigns the receiver, subject and body for email
            string subject = "Order on " + DateTime.Now;
            int childCount = model.transform.childCount;
            String[] items = new String[childCount];
            String body="";
            //stores all children under shirt/Tshirt (collar,button,cuff,etc) in an array
            for (int i = 0; i < childCount; i++)
            {
                items[i] = model.transform.GetChild(i).name;
            }
            //gets the name of the material used
            String[] material = model.GetComponent<Renderer>().material.name.Split(' ');
            body += material[0] + " | ";
            body += model.GetComponent<Renderer>().material.color + " | ";
            //selects unique elements from children(discards multiple clones of buttons and cuffs)
            HashSet<String> newList = new HashSet<String>(items);
            foreach (String item in newList)
            {
                String[] component = item.Split('(');
                body += component[0] + " | ";
            }
            //opens the default emailing app and assigning the details of the shirt/Tshirt
            Application.OpenURL("mailto:" + receiver.text + "?subject=" + subject + "&body=" + body);
        });
    }
}
