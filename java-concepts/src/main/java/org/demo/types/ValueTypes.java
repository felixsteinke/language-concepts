package org.demo.types;

public class ValueTypes {

    boolean booleanVariable = true;
    short shortIntegral = Short.MAX_VALUE; // 32767
    int integral = Integer.MAX_VALUE; // 2147483647
    long longIntegral = Long.MAX_VALUE; // 9223372036854775807L
    float shortDecimal = Float.MAX_VALUE; // 3.4028235E38f
    double decimal = Double.MAX_VALUE; // 1.7976931348623157E308
    char singleCharacter = 'A';

    enum OrdinalEnum {
        E1, E2, E3
    }
}
