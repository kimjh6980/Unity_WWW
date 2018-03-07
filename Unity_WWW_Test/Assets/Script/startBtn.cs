using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class startBtn : MonoBehaviour {

    private string LoginUrl;

    private string ID;
    public Text InputEmailText;

	// Use this for initialization
	void Start () {
        LoginUrl = "http://teama-iot.calit2.net/signinapp";
    }

    // Update is called once per frame
    void Update () {
		
	}

    public void startGame()
    {
        ID = InputEmailText.text;
        Debug.Log("ID = " + ID);

        StartCoroutine(LoginCo());
    }

    IEnumerator LoginCo()
    {
        WWWForm form = new WWWForm();
        form.AddField("who", "0");
        form.AddField("useremail", ID);
        form.AddField("userpassword", "hiella123");

        WWW webRequest = new WWW(LoginUrl, form);

        StartCoroutine(WaitForRequest(webRequest));

        Debug.Log(webRequest.text);
        yield return webRequest;
    }

    IEnumerator WaitForRequest(WWW www)
    {
        yield return www;
        if (www.error == null)
        {
            // request completed!
            Debug.Log(www.text);
        }
        else
        {
            // something wrong!
            Debug.Log("WWW error: " + www.error);
        }
    }
}
