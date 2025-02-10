using CCGKit;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IPConfigurator : BaseScreen
{
    [SerializeField] private TMP_InputField mIPInputField;
    
    public void OnJoinClicked()
    {
        if (mIPInputField.text != null)
        {
            GameNetworkManager.Instance.networkAddress = mIPInputField.text;
        }
        else
        {
            OpenPopup<PopupOneButton>("PopupOneButton", popup =>
            {
                popup.text.text = "Provided IP Invalid";
                popup.buttonText.text = "Close";
                popup.button.onClickEvent.AddListener(() => { popup.Close(); });
            });
        }
        GameNetworkManager.Instance.StartClient();
    }

    public void OnBackButtonClicked()
    {
        SceneManager.LoadScene("Lobby");
    }
}
