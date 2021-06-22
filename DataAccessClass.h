/*
 * DataAccessClass.h
 *
 *  Created on: Jun 3, 2021
 *      Author: dangj3
 */



#include <sqlite3.h>
#include "DatabaseCommands.h"


class DAO{

public:
	DAO();
	DAO(sqlite3* database);
	//~DAO();

	void addPlanet(std::string name, double mass);


};
