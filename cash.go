/******************************************************************************
Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
package main
import (
         "fmt"
 )

 func main() {

         var f float64

         fmt.Println("Enter a float value : ")
         _, err := fmt.Scanf("%f", &f)

         if err != nil {
            fmt.Println(err)
         }

         fmt.Printf("You have entered : %f \n", f)

         f = f * 100
         var value int = int(f)
         
         var counter int = 0
         
        fmt.Println(value) 
         
        for value >= 25 {
		value = value - 25;
        counter = counter + 1;
        }
        
        for value >= 10 {
		value = value - 10;
        counter = counter + 1;
        }
        
        for value >= 5 {
		value = value - 5;
        counter = counter + 1;
        }
        
        for value >= 1 {
		value = value - 1;
        counter = counter + 1;
        }
        
    
        fmt.Println(counter)
        

 }
