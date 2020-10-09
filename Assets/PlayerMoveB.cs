using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.SceneManagement;
using Bolt;
using Ludiq;
using UnityAndroidBluetooth;

public class PlayerMoveB : MonoBehaviour
{
    // Start is called before the first frame update
    BluetoothControl Btcontrol;
    void Start()
    {
        Btcontrol = BluetoothControl.Instance;
    }
    public void BTConexion()
    {
        if (Btcontrol.GetButton("Left").IsClicked)
        {
            Variables.ActiveScene.Set("BtnLeft", "Pressed");
        }
        else
        {
            Variables.ActiveScene.Set("BtnLeft", "nopressed");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
