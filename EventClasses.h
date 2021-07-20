
#ifndef EVENTCLASSES_H
#define EVENTCLASSES_H
#include <antikythera.db>
#include <sqlite3.h>
#include <string>
#include <iostream>
#include <cstdlib>


class EventList {
	private:
	std::string Planetlist;
	std::string EclipseList;
	std::string SpaceEventsList;

	
};
	public :
	EventList(){
		Planetlist =  "SELECT * FROM PLANETS;";
		EclipseList = "SELECT * FROM ECLIPSES;";
		SpaceEventsList = = "SELECT * FROM SPACEEVENTS;";
		
	}
	void searchbydate () //current date or past date 
	{	
		int decisionz;
		std::cout<< "Search By Date " << std:: endl; 
		std::cout<< "Current Date (1) "<<std::endl;
		std::cout<< "Choose my date (2)" << std::endl; 
		std::cin >> decisionz;
		switch (decisionz)
		{
		case 1: 
		//calculate current date values here
		geteclipse(m,d);
		getevents(m,d); 
		break; 
		case 2: 
		int m;
		int d;
		std::cout<< "Insert Month (1-12)"<<std::endl;
		std::cin>>m;
		std::cin>>d;
		geteclipse(m,d);
		getevents(m,d);
		break;
		default: 
		std::cout<< "Invalid value Goodbye" << std::endl;
		break;
			
		}
		
	}
};

class Planets{
	private: 
	std::string planetname; 
	std::string planetz;
	public :
	Planets () 
	{
	planetz = "SELECT * FROM PLANETS;";	
	}
	void getPlanet ( std::string planetname) {
		"SELECT FROM PLANETS WHERE planetName = "+ planetname+";";
	}
	
};



class Events : public EventList  {
	private :
	std::string temp;
	std::string eventz;
	public: 
	Events () {
		eventz = "SELECT * FROM SpaceEvents;";
	}
	void getevents (int month, int day) {
		temp = "SELECT FROM SpaceEvents WHERE Month = "+ std::to_string(month) +" AND Day = "+ std::to_string(day)+";";
	}
		};


	



#endif