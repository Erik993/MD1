﻿using System;
using Library;
namespace Factories;

public class EmployeeFactory
{
    public Employee Createitem(int index)
    {
        var rand = new Random();
        int randNum = rand.Next(0, 1000);

        return new Employee(
            id: index,
            name: $"employee{randNum}",
            email: $"employee{randNum}@gmail.com",
            isactive: index % 2 == 0,
            contractDate: DateTime.Now
            );
    }

}
