package org.demo.expressions;

public class Expressions {
    public void arithmeticExpressions() {
        int a = 1;
        int b = 2;

        System.out.println("Increment: " + (a++));
        System.out.println("Decrement: " + (a--));
        System.out.println("Plus: " + (a + b));
        System.out.println("Minus: " + (a - b));
        System.out.println("Multiplication: " + (a * b));
        System.out.println("Division: " + ((float) a / b));
        System.out.println("Remainder (Modulo): " + (-5.2f % 2.0f));
    }

    public void logicalExpressions() {
        boolean a = true;
        boolean b = false;

        System.out.println("Negation: " + (!a));
        System.out.println("AND: " + (a && b));
        System.out.println("OR: " + (a || b));
        System.out.println("XOR: " + (a ^ b));
        System.out.println("Negation: " + (!a));
    }

    public void orderExpressions() {
        int a = 1;
        int b = 2;

        System.out.println("Less Than: " + (a < b));
        System.out.println("Less Than or Equal: " + (a <= b));
        System.out.println("Greater Than: " + (a > b));
        System.out.println("Greater Than or Equal: " + (a >= b));
    }

    public void equalityExpressions() {
        int valueType1 = 1;
        int valueType2 = 1;

        System.out.println("Equal: " + (valueType1 == valueType2));
        System.out.println("Not Equal: " + (valueType1 != valueType2));

        String referenceType1 = "1";
        String referenceType2 = "1";

        System.out.println("Equal: " + (referenceType1.equals(referenceType2)));
        System.out.println("Not Equal: " + (!referenceType1.equals(referenceType2)));
        System.out.println("Equal memory reference: " + (referenceType1 == referenceType2));
    }
    
    public void ternaryOperator() {
        boolean condition = true;
        String result = condition ? "True value" : "False value";
    }
}
