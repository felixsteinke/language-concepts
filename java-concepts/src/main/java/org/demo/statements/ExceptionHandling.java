package org.demo.statements;

import java.io.FileInputStream;
import java.io.InputStreamReader;

public class ExceptionHandling {

    public void handleException() {
        try (InputStreamReader reader = new InputStreamReader(new FileInputStream("non existent"))) {
            System.out.println(reader.read());
        } catch (Exception e) {
            System.out.println("Got " + e.getClass().getSimpleName() + ": " + e.getMessage());
        } finally {
            // reader.close() required if no catch with resources
            System.out.println("Always gets executed!");
        }
    }

    public void throwException() throws Exception {
        throw new Exception ("Unhandled Exception");
    }
}
