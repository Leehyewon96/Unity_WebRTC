using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.WebRTC;


namespace Unity.WebRTC.Samples
{
    class MyPlayerScript : MonoBehaviour
    {
        RTCPeerConnection localConnection;
        RTCConfiguration config = default;

        private void Awake()
        {
            WebRTC.Initialize();
        }

        private void Call()
        {
            localConnection = new RTCPeerConnection();
            config.iceServers = new[] { new RTCIceServer { urls = new[] { "stun:stun.l.google.com:19302" } } };



        }
    }
}
