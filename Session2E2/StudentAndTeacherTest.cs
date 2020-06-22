using System;

namespace Session2E2{
    public class StudentAndTeacherTest{
        static void Main(string[] args){
            Person person=new Person("Eduardo Martinez ",20);
            Student student=new Student("Vicenet Eduardo Martinez ",20);
            Teacher teacher=new Teacher();

            person.hello();
           // student.setRasgos("Vicenet Eduardo Martinez ",20);
            student.ShowAge();
            teacher.setRasgos("Esduarso Orosco",30);
            teacher.hello();
            teacher.Explain();

        }
    }
}
