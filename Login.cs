using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Text.RegularExpressions;
using UnityEngine.UI;

public class Login: MonoBehaviour {
    public GameObject username;
    public GameObject password;
    private string Username;
    private string Password;
	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (Username != "" && Password != "")
            {
                LoginButton();
            }
        }
        Username = username.GetComponent<InputField>().text;
        Password = password.GetComponent<InputField>().text;
    }

    private void LoginButton()
    {
        print("Login Successful");
    }
}
