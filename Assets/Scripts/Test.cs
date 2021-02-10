using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class Test : MonoBehaviour
{
    public Text OwnerObject;
    private List<string> Charactors = new List<string>();

    // Start is called before the first frame update
    void Start()
    {
        try
        {
            var fileName = "schoolprojectdb.db";
            var db = new SqliteDatabase(fileName);
            var query = db.ExecuteQuery("SELECT * FROM user");

            foreach (var row in query.Rows)
            {
                var id = row["u_id"];
                var name = row["u_name"];
                var mail = row["mail"];
                var password = row["password"];

                var text = $"ID:{id}, \r\nName:{name}, \r\nMail:{mail}, \r\nPassword:{password}\r\n";

                Charactors.Add(text);
            }

        } 
        catch (Exception ex)
        {
            Charactors.Add(ex.Message);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (OwnerObject != null && Charactors.Count > 0)
        {
            string text = "";
            
            if (Charactors.Count > 0)
            {
                text = string.Join("\r\n", Charactors);
            }
            else
            {
                text = "キャラクターが存在しません";
            }

            OwnerObject.text = text;
        }
    }
}