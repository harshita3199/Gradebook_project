using System;
using System.Collections.Generic;


namespace Gradebook{
     public class Book{
         

        //defining constructor as same name as that of class
        public Book(string name){
            grades= new List<double>();
            Name=name;

        }

        public void AddGrade(double grade){
           grades.Add(grade);

       } 
       public Statistics GetStatistics(){

           var result=new Statistics();
            result.Average=0.0;
            result.High=double.MinValue;
            result.Low=double.MaxValue;


            // var grades=new List<double>() {12.7,10.3,4.00,6.11};
            // grades.Add(56.1);

            // grades.Remove(10.3);

            // Console.WriteLine(grades[0]);
           
           
           foreach( var grade in grades){
                // highGrade=Math.Max(number,highGrade);
                // LowestGrade=Math.Min(number,LowestGrade);
                if(grade> result.High){
                    result.High=grade;
                }
                if(grade< result.Low){
                    result.Low=grade;
                }
                result.Average+=grade;   
            }

             result.Average/= grades.Count;

            return result;
             
       }

       
       public List<double> grades;   //legally allowed to access the grades class as now it is public.
    //    private List<double> grades;  
       public string Name;   
    }
}