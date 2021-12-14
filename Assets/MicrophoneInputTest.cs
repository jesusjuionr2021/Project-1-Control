using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;



public class MicrophoneInputTest : MonoBehaviour
{

    public float loudness = 0;
    public float sensitivity = 1000;
    private AudioSource audio;
    public GameObject sphere;
    private string _SelectedDevice;
    //public Text DebugText;
    //public Text DebugText2;
    //public Text DebugText3;
    private string[] devices;


    // Start is called before the first frame update
    void Start()
    {


        _SelectedDevice = Microphone.devices[0].ToString();
        audio = GetComponent<AudioSource>();
        if(audio != null)
        {
            audio.clip = Microphone.Start(_SelectedDevice, true, 10, 48000);
            audio.loop = true;
            while (!(Microphone.GetPosition(null) > 0)) { }
            audio.Play();
        }
        
        

        //DebugText3.text = "Is the Microphone Recording?: " + Microphone.IsRecording(_SelectedDevice);



        //DebugText.text = "The selected device is:" + _SelectedDevice;

    }

    // Update is called once per frame
    void Update()
    {
        loudness = GetAverageVolume() * sensitivity;
        Debug.Log(loudness);
        //sphere.transform.position += new Vector3(0, loudness, 0);

        sphere.transform.localScale = Vector3.one * loudness;
        //DebugText2.text = "loudness is: " + loudness;
    }

    float GetAverageVolume()
    {
        float[] data = new float[256];
        float a = 0;
        audio.GetOutputData(data, 0);
        foreach (float s in data)
        {
            a += Mathf.Abs(s);
        }
        return a / 256;
    }


}
