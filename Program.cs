using System;
using Library;
using Application;

/*
Abstract Class directory contains:
* User abstract class
* List abstract class to managa collections

Data - directory created for json files

Factories - contains methods to create specific objects

Interfaces - IDatamanager interface

Library - contains Assignment, Employee, ItSuppor, Ticket classes

Repositories - collections for each type of object, that inherit from AbstractList.

Services - JSON manager

Application - Application data manager aggregates and manages all classes

github:
https://github.com/Erik993/MD1.git

*/


var dm = new ApplicationDataManager();

// CreateTestData argument: integer is a count of test objects.
dm.CreateTestData(1);
dm.Print();
dm.Save();
dm.Reset();
dm.Print();
dm.Load();
dm.Print();

