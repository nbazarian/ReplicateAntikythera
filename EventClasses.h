
#ifndef EVENTCLASSES_H
#define EVENTCLASSES_H
#include <antikythera.db>
#include <sqlite3.h>
#include <string>


class EventList {
	private:
	std::string eventtype;
	std::string eventdate; 
	public :
	EventList(){
		
	}
	void searchbyType(){}
	void searchbyDate(){}
};

class Planets : public EventList{
	private: 
	std::string planetname; 
	int planetPeriod;
	int planetSpeed; 
	int planetDist;
	int planetMass; 
	std::string planetType; 
	public :
	Planets () 
	{
		
	}
	void getPNames ( int pattr) {}
	void getOP (std::string n ) {} 
	void getOS ( std::string n ) {} 
	void getPlanetM (std::string n) {} 
	void getPlanetT (std::string T) {} 
};

class Eclipses: public EventList  {
	private :
	std::string dateOcc; 
	std::string Ectype;
	std::string EcLocation; 
	public:
	Eclipses () 
	{
		
	}
	void getDates ( std::string loc) {} 
	void getLocation (std:: string dat ) {} 
	void getType (std::string date ) {} 
};

class Events : public EventList  {
	private :
	std::string EventName; 
	std::string EventType; 
	std::string DateOccurs; 
	int Speed; 
	int LocationLat; 
	int LocationLong; 
	std::string Direction; 
	public: 
	Events () {
		
	}
	void getEventN(int Dat) { }
	void getEventT(std::string nombre) { } 
	void getDate (std::string nombre ) { } 
	void getSpeed (std::string nombre) { } 
	void getLocation (std::string nombre) {} 
	void getDir (std::string nombre ) { } 
};


	



#endif