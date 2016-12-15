﻿using UnityEngine;
using System.Collections;
using System.Net;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;
using uPLibrary.Networking.M2Mqtt.Utility;
using uPLibrary.Networking.M2Mqtt.Exceptions;
using UnityEngine.UI;
using System;


public class mqttTest : MonoBehaviour {

	private MqttClient client;

	public Text mspPowerText;
    public String mspPowerTopic = "/msp/";
	public String mqttMsg;

    // public String mqttServerAdress = "213.168.249.129";

    // Use this for initialization
    void Start () {
		// create client instance 
		client = new MqttClient(IPAddress.Parse("213.168.249.129"),1883 , false , null ); 
		
		// register to message received 
		client.MqttMsgPublishReceived += client_MqttMsgPublishReceived; 
		
		string clientId = Guid.NewGuid().ToString(); 
		client.Connect(clientId);

        // subscribe to the topic mspPowerTopic with QoS 2 
		client.Subscribe(new string[] { "/msp/power/" }, new byte[] { MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE }); 

	}


	void client_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e) { 

		//Debug.Log("Received: " + System.Text.Encoding.UTF8.GetString(e.Message)  );
		mqttMsg = System.Text.Encoding.UTF8.GetString (e.Message);
		Debug.Log(mqttMsg);

	} 

	/*

	void OnGUI(){
		if ( GUI.Button (new Rect (20,40,80,20), "Level 1")) {
			Debug.Log("sending...");
			client.Publish("/msp/chat/", System.Text.Encoding.UTF8.GetBytes("MSP Unity connected"), MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, true);
			Debug.Log("sent");
		}
	}
	
	*/

	// Update is called once per frame
	void Update () {
		mspPowerText.text = mqttMsg;
	}
}
