package org.demo.statements;

import java.time.DayOfWeek;

public class Statements {

    void iterationStatementFor(){
        for (int i = 0; i < 5; i++) {
            if (i == 3) {
                System.out.println("Skip the 3!");
                continue;
            }
            System.out.println("Loop on i: " + i);
        }

        for (DayOfWeek day : DayOfWeek.values()) {
            System.out.println("Loop on collection: " + day);
        }
    }

    void iterationStatementWhile(){
        boolean condition = false;

        while (condition){
            System.out.println("Loop until condition is false!");
        }

        do {
            System.out.println("Loop at least once!");
        } while (condition);
    }

    void selectStatementIf(){
        String day = "Monday";
        if (day.contains("e")){
            System.out.println("Branch 1");
        } else if (day.contains("a")){
            System.out.println("Branch 2");
        } else {
            System.out.println("Default Branch");
        }
    }

    void selectStatementSwitch(){
        DayOfWeek day = DayOfWeek.MONDAY;
        switch (day) {
            case FRIDAY:
                System.out.println("Great!");
                break;
            case SATURDAY, SUNDAY:
                System.out.println("Even better!");
                break;
            default:
                System.out.println("Could be better...");
        }
    }
}
