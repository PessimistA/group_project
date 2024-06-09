using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class pass : MonoBehaviour
{
    public InputField passwordInputField;
    public Button toggleButton;

    private bool isPasswordVisible = false;

    void Start()
    {
        if (passwordInputField == null)
        {
            Debug.LogError("Password Input Field is not assigned in the Inspector.");
            return; 
        }

        if (toggleButton == null)
        {
            Debug.LogError("Toggle Button is not assigned in the Inspector.");
            return;
        }
        passwordInputField.contentType = InputField.ContentType.Password;//başlangıçta direkt olarak password halinde atama yapmasını sağlar
        passwordInputField.ForceLabelUpdate();


        toggleButton.onClick.AddListener(TogglePasswordVisibility);
    }

    void TogglePasswordVisibility()
    {

        isPasswordVisible = !isPasswordVisible;

        if (isPasswordVisible)
        {

            passwordInputField.contentType = InputField.ContentType.Standard;//bu kısım * olmayan şifrenin görünen kısmını aktif etmedir
        }
        else
        {

            passwordInputField.contentType = InputField.ContentType.Password;//bu kısım ise inputfieldlar arasında şifrenin * halini sağlar
        }


        passwordInputField.ForceLabelUpdate();//yazıyı değiştiren kısım
    }
}
