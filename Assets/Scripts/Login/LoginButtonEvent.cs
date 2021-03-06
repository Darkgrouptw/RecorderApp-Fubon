﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoginButtonEvent : MonoBehaviour
{
    public InputField AccountField;
    public InputField PasswordField;

    // 預測帳密，快速登入
    public void TestButtonPressEvent()
    {
        if(AccountField.text != "abc")
        {
            AccountField.text = "abc";
            PasswordField.text = "123";
        }
        else
        {
            AccountField.text = "abcd";
            PasswordField.text = "1234";
        }
    }

    public void LoginButtonPressEvent()
    {
        if((AccountField.text == "abc" && PasswordField.text == "123") ||
            (AccountField.text == "abcd" && PasswordField.text == "1234"))
        {
            PlayerPrefs.SetString("Account", AccountField.text);
            PlayerPrefs.SetString("Password", PasswordField.text);
            SceneManager.LoadSceneAsync(1);
        }
    }
}
