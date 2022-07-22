package org.demo.types;

public class ReferenceTypes {

    String characterSequence = "ABC";
    String[] singleDimArray = {"x1", "x2", "x3"}; // new String[3];
    String[][] twoDimArray = {{"x1,y1", "x1,y2"}, {"x2,y1", "x2,y2"}};

    interface DemoInterface {
        void demoMethod();
    }

    class DemoClass extends Object implements DemoInterface {
        @Override
        public void demoMethod() {
            System.out.println("Do something!");
        }
    }
}
