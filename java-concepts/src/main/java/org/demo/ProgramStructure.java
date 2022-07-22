package org.demo;

public class ProgramStructure {

    public static void main(String[] args) {
        Person person = new Person();
        System.out.println(person.tell("Hello World!"));
    }

    public static class Person {
        private int id;
        protected char gender;
        public String name;

        public Person() {
            this.id = 1;
            this.gender = 'm';
            this.name = "Mario";
        }

        public String tell(){
            return "Hello my name is " + name;
        }

        public String tell(String message){
            return tell() + ": " + message;
        }
    }
}


