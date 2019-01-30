using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Text.RegularExpressions;
using UnityEngine.UI;

public class Register : MonoBehaviour
{
    public GameObject username;
    public GameObject email;
    public GameObject password;
    public GameObject confpassword;
 
    private string Username;
    private string Email;
    private string Password;
    private string ConfPassword;
    private string form;
    private bool EmailValid = false;

    // Use this for initialization
    void Start ()
    {
        //password = GameObject.FindGameObjectWithTag("password");
    }
	public void RegisterButton()
    {
        bool UN = false;//Username
        bool EM = false;//Email
        bool PW = false;//Password
        bool CPW = false;//Confirm Password
        //Check if the input username is stored and correct
        if (Username != " "){
            if (System.IO.File.Exists(@"C:\Users\Admin\Documents\Registration Account\Assets\Account Registration" + Username + ".txt")){
                UN = true; //if the input username is put, set true
            }
            else{
                //reference to the check IO
                Debug.LogWarning("Username taken");
            }
        }
        //reference to the input username
        else{
            Debug.LogWarning("Enter Username");
        }
        //check is the email is input
        if(Email != " "){
            //check if the email is valid
            if (EmailValid)
            {
                //check email contains @
                if (Email.Contains("@"))
                {
                    //check if email contain "."
                    if (Email.Contains("."))
                    { 
                        EM = true;
                    }else{
                        //it not, set Email is invalid
                        Debug.LogWarning("Email is invalid");
                    }
                }else{
                    Debug.LogWarning("Email is invalid");
                }
            }else{
                Debug.LogWarning("Email is invalid");
            }
        }else{
            Debug.LogWarning("Email field empty");
        }
        //check password is input
        if(Password != " ")
        {
            //check if the password has more than 5 characters
            if(Password.Length > 5)
            {
                PW = true;
            }else{
                //if not, tell it has to be at least 6 characters
                Debug.LogWarning("Password must contain at least 6 characters");
            }
        }else{
            Debug.LogWarning("Password field is empty");
        }
        //check if Confirm password macthes the input password
        if (ConfPassword != " ")
        {
            if (ConfPassword == Password)
            {
                CPW = true;
            }else{
                Debug.LogWarning("Your password doesn't match");
            }
        }else{
            Debug.LogWarning("Confirm password field is empty");
        }
        
    }
	// Update is called once per frame
	void Update ()
    {
        //reference if the input key is on input field
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (username.GetComponent<InputField>().isFocused) //isFocused
            {
                email.GetComponent<InputField>().Select();
            }
            if (email.GetComponent<InputField>().isFocused)
            {
                password.GetComponent<InputField>().Select();
            }
            if (password.GetComponent<InputField>().isFocused)
            {
                confpassword.GetComponent<InputField>().Select();
            }
        }
        //check if password is matched with confirm password
        if (password.GetComponent<InputField>() == confpassword.GetComponent<InputField>())
        {
            if (Input.GetKeyDown(KeyCode.Return))
            {
                if (Username != " " && Email != " " && Password != " " && ConfPassword != " ")
                {
                    RegisterButton();
                }
            }
        }
        
        Username = username.GetComponent<InputField>().text;
        Email = email.GetComponent<InputField>().text;
        Password = password.GetComponent<InputField>().text;
        ConfPassword = confpassword.GetComponent<InputField>().text;
    }
}

