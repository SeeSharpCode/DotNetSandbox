package com.jbhunt.sandbox;

public class Enums {
    public enum JobTitle {
        Programmer,
        ProgrammingAnalyst,
        ProgrammingSpecialist
    }

    private class Employee {
        JobTitle jobTitle;
    }
}
