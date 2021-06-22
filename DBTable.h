/*
 * DBTable.h
 *
 *  Created on: Jun 16, 2021
 *      Author: dangj3
 */

#ifndef DBTABLE_H_
#define DBTABLE_H_

#include <iostream>
#include <string>
#include <vector>

//Basic container for the query data
struct Table{
	std::vector<std::string> singleRow;
	std::vector<std::vector<std::string>> fullTable;
};

#endif /* DBTABLE_H_ */
