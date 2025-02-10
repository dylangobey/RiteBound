using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using UnityEngine;

public class IPDisplayer : MonoBehaviour
{
    private void Start()
    {
        string localIP = GetLocalIPAddress();
        Debug.Log($"IP: {localIP}");
    }

    string GetLocalIPAddress()
    {
        try
        {
            foreach (var netInterface in Dns.GetHostAddresses(Dns.GetHostName()))
            {
                if (netInterface.AddressFamily == AddressFamily.InterNetwork)
                {
                    return netInterface.ToString();
                }
            }
        }
        catch{}

        return "IP Not Found!";
    }
}
