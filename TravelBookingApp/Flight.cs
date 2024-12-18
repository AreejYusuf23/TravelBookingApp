///////////////////////////////////////////////////////////
//  Flight.cs
//  Implementation of the Class Flight
//  Generated by Enterprise Architect
//  Created on:      07-Dec-2024 8:52:23 PM
//  Original author: mayar
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



public class Flight {

	private String airportName;
	private Airport arrivalAirport;
	//private Time arrivalTime;
	private Airport dapartureAirport;
	//private Time departureTime;
	private string flightNumber;
	private int numberOfPassenger;
	private Traveller[] passengersList;
	private Plane plane;
	private double price;
	private int terminalNumber;
	public Destination m_Destination;
	public Booking m_Booking;

	public Flight(){

	}

	~Flight(){

	}

}//end Flight